from flask import Flask, url_for, render_template, redirect

app = Flask(__name__)

# @app.route('/')
# def home():
# 	return render_template('lds.html')

# @app.route('/stromgard')
# def stromgard():
# 	return render_template('stromgard.html')

@app.route('/nicebowling')
def nb():
	return render_template('nicebowling.html')

# Error handlers
@app.errorhandler(404)
def page_not_found(e):
    return redirect(url_for('home'))

@app.errorhandler(500)
def internal_server_error(e):
    return redirect(url_for('home'))

if __name__ == '__main__':
	app.run(debug=True)
    #app.run(host='0.0.0.0')


