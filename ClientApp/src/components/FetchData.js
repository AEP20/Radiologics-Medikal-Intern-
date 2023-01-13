import React,{useEffect, useState} from 'react'

function FetchData() {

    const [data, setData] = useState([])

    useEffect(() => {
        async function fetchData() {
            const response = await fetch('patient',{
                method: 'GET',
            })
            const data = await response.json()
            setData(data)
        }
        fetchData()
    }, [])


  return (
    <table className='table table-striped table-dark' aria-labelledby="tabelLabel">
        <thead>
            <tr>
                <th>name</th>
                <th>ID</th>
                <th>Disease</th>
            </tr>
        </thead>
        <tbody>
            {data.map((item, index) => (
                <tr key={index}>
                    <td>{item.name}</td>
                    <td>{item.id}</td>
                    <td>{item.disease}</td>
                </tr>
            ))}
        </tbody>
    </table>
    
    

                
  )
}

export default FetchData