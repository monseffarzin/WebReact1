import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Hello, from <b>Farzin Monsef</b></h1>
        <br/>
        <p>Welcome to our simple new single-page application, for calculating purchased points:</p>
        <p>Push the <a class="text-dark" href="/fetch-data"><b>Fetch Purchased Points</b></a> to see the purchased amounts spent, along with the calculated points next to it.</p>
      </div>
    );
  }
}
