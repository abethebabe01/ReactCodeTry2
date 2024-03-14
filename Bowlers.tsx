import React, { useState, useEffect } from 'react';
import axios from 'axios';

function Bowlers() {
  const [bowlers, setBowlers] = useState([]);

  useEffect(() => {
    fetchBowlers();
  }, []);

  const fetchBowlers = async () => {
    try {
      const response = await axios.get('YOUR_API_ENDPOINT_HERE');
      setBowlers(response.data);
    } catch (error) {
      console.error('Error fetching bowlers:', error);
    }
  };

  return (
    <div>
      <h1>Bowlers</h1>
      <table>
        <thead>
          <tr>
            <th>Name</th>
            <th>Team</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((bowler, index) => (
            <tr key={index}>
              <td>{`${bowler.firstName} ${bowler.middleName} ${bowler.lastName}`}</td>
              <td>{bowler.teamName}</td>
              <td>{bowler.address}</td>
              <td>{bowler.city}</td>
              <td>{bowler.state}</td>
              <td>{bowler.zip}</td>
              <td>{bowler.phoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default Bowlers;
