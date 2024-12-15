from flask import Flask, url_for, render_template, redirect, make_response
import datetime
import randomizer

app = Flask(__name__)

expires = (datetime.datetime.now(datetime.timezone.utc) + datetime.timedelta(hours=72)).strftime('%a, %d %b %Y %H:%M:%S GMT')

@app.route('/')
def home():
	response = make_response(render_template('lds.html', data=randomizer.lds()))
	response.headers['Expires'] = expires
	return response

@app.route('/stromgard')
def stromgard():
	response =  make_response(render_template('stromgard.html'))
	response.headers['Expires'] = expires
	return response

@app.route('/nicebowling')
def nb():
	response =  make_response(render_template('nicebowling.html'))
	response.headers['Expires'] = expires
	return response

@app.route('/sumospin')
def sumospin():
	response =  make_response(render_template('sumospin.html'))
	response.headers['Expires'] = expires
	return response

# Error handlers
@app.errorhandler(404)
def page_not_found(e):
    return redirect(url_for('home'))

@app.errorhandler(500)
def internal_server_error(e):
    return redirect(url_for('home'))

if __name__ == '__main__':
	#app.run(debug=True)
    app.run(host='0.0.0.0')


