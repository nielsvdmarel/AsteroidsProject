var doc = app.activeDocument;
    
if (documents.length > 0){
        
    // Create the illusrtratorSaveOptions object to set the AI options
    var saveOpts = new IllustratorSaveOptions();
    
    // Setting IllustratorSaveOptions properties. 
    saveOpts.embedLinkedFiles = true;
    saveOpts.fontSubsetThreshold = 0.0
    saveOpts.pdfCompatible = true
 
        
        if (doc.saved==false) doc.save();
        
        for (i=0; i<doc.layers.length; i++)
            if (doc.layers[i].locked == false) doc.layers[i].visible = false;
        fullDocName = doc.fullName;
        var param = doc.name.split('.');
        realDocName = param[0];
        for (i=0; i<doc.layers.length; i++){
            if (i-1<0) doc.layers[i].visible = true;
            else {
                doc.layers[i-1].visible = false;
                doc.layers[i].visible = true;
            }
            if (doc.layers[i].locked == false) {    
                docName = realDocName+doc.layers[i].name+".ai";    
                var saveName = new File ( doc.path + "/" + docName );
                doc.saveAs( saveName, saveOpts );
            }
        }
        doc.close(SaveOptions.DONOTSAVECHANGES);
        doc = null;
        app.open (fullDocName);
    }