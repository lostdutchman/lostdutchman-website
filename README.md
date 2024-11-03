## Starting Flask

Open project in VSC, in website folder open tcm.rpy
Run \\ F5
In the Powershell pane, it will render a URL you can CTRL Click to open in a browser window
Rereun to see major changes

## URLs in Flask 

Flask uses 2 folders to track content
 - templates = HTML Files
 - static = All other content
   
All URLs need to be in this format - {{url_for('templates/static', filename='/path/to/file.ext')}}
## EXAMPLES ##:
- To link to another HTML file  - {{url_for('static', filename='/tcm.html')}}
- To link to a image - {{url_for('static', filename='/tcm/images/navbarbrand.png')}}
- To link to a css file - {{url_for('static', filename='/tcm/scripts/style.css')}}

## Page Routing

tcm.py handels routing and errors. To add a new page to the website add a new app.route above the error handlers

For example this would add a page for Mori as long as there is a mori.html in the templates folder:

```
@app.route('/mori')
def mori():
	return render_template('mori.html')
```

## Build Automation

When code is commited Git Hub will automaticly build a new docker image and push it to docker hub. Then both servers will automaticly pull the image from docker hub and run it. The website should reflect any changes withing 10-15min.
If changes are not reflected check the Actions tab in the github repository. 
 - If action has failed you can re-try it.
 - If action has not failed Jeremy will need to log into docker hub to verify the image was pushed and pulled.
