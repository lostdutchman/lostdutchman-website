from flask import url_for
import random

def lds():
    urls = [
        [url_for("sumospin"), url_for('static', filename='lds/images/sumospin.webp'), 'Sumo Spin logo'],
        [url_for("sumospin"), url_for('static', filename='lds/images/sumospin.webp'), 'Sumo Spin logo'],
        [url_for("sumospin"), url_for('static', filename='lds/images/sumospin.webp'), 'Sumo Spin logo'],
        [url_for("nb"), url_for('static', filename='lds/images/nicebowling.webp'), 'Nice Bowling logo'],
        [url_for("nb"), url_for('static', filename='lds/images/nicebowling.webp'), 'Nice Bowling logo'],
        [url_for("nb"), url_for('static', filename='lds/images/nicebowling.webp'), 'Nice Bowling logo'],
        [url_for("stromgard"), url_for('static', filename='lds/images/stromgard.webp'), 'The Wyrd of Stromgard Logo'],
        [url_for("stromgard"), url_for('static', filename='lds/images/stromgard2.webp'), 'The Wyrd of Stromgard GM screen art'],
        [url_for("stromgard"), url_for('static', filename='lds/images/stromgard.webp'), 'The Wyrd of Stromgard Logo'],
        ['http://tricitymonsters.com', url_for('static', filename='lds/images/tcm.webp'), 'Tri City Monsters logo'],
        ['http://tricitymonsters.com', url_for('static', filename='lds/images/tcm.webp'), 'Tri City Monsters logo'],
        ['http://tricitymonsters.com', url_for('static', filename='lds/images/tcm.webp'), 'Tri City Monsters logo']
    ]
    random.shuffle(urls)
    return urls