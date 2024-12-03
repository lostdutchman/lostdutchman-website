from flask import url_for
import random

def lds():
    urls = [
        [url_for("sumospin"), url_for('static', filename='lds/images/sumospin1.webp'), 'Sumo Spin logo'],
        [url_for("sumospin"), url_for('static', filename='lds/images/sumospin2.webp'), 'Sumo Spin logo'],
        [url_for("sumospin"), url_for('static', filename='lds/images/sumospin3.webp'), 'Sumo Spin logo'],
        [url_for("nb"), url_for('static', filename='lds/images/nicebowling1.webp'), 'Nice Bowling logo'],
        [url_for("nb"), url_for('static', filename='lds/images/nicebowling2.webp'), 'Nice Bowling logo'],
        [url_for("nb"), url_for('static', filename='lds/images/nicebowling3.webp'), 'Nice Bowling logo'],
        [url_for("stromgard"), url_for('static', filename='lds/images/stromgard1.webp'), 'The Wyrd of Stromgard Logo'],
        [url_for("stromgard"), url_for('static', filename='lds/images/stromgard2.webp'), 'The Wyrd of Stromgard GM screen art'],
        ['http://tricitymonsters.com', url_for('static', filename='lds/images/tcm1.webp'), 'Tri City Monsters logo'],
        ['http://tricitymonsters.com', url_for('static', filename='lds/images/tcm2.webp'), 'Tri City Monsters logo'],
        ['http://tricitymonsters.com', url_for('static', filename='lds/images/tcm3.webp'), 'Tri City Monsters logo'],
        ['http://tricitymonsters.com', url_for('static', filename='lds/images/tcm4.webp'), 'Tri City Monsters logo']
    ]
    random.shuffle(urls)
    return urls