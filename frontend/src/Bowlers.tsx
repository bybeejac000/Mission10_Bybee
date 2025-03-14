import { useEffect, useState } from 'react';
import { bowler } from './types/bowler';

function BowlerList() {
  const [bowlers, setFoods] = useState<bowler[]>([]);

  useEffect(() => {
    const fetchBowler = async () => {
      const response = await fetch('http://localhost:3000/api/BowlingAPI');
      const data = await response.json();
      setFoods(data);
    };

    fetchBowler();
  }, []);

  return (
    <>
      <h1>Bowlers</h1>
      <table border="1" align="center">
        <thead>
          <tr>
            <th>First Name</th>
            <th>Middle Initial</th>
            <th>Last Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((b) => (
            <tr>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerMiddleName}</td>
              <td>{b.bowlerLastName}</td>
              <td>{b.teamName}</td>
              <td>{b.address}</td>
              <td>{b.city}</td>
              <td>{b.state}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.phone}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
