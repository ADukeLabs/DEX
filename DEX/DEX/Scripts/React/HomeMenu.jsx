class Menu extends React.Component {
    Render() {
        return <button>Wellington, New Zealand</button>;

        //<div className="city-div">
        //           <button className='city-button btn btn-primary btn-block' type="button"></button>
        //       </div>;
    }

}

class App extends React.Component {
    Render() {
        return <div>
                <Menu />
               </div>;
    }
}

ReactDOM.Render(
    <App/>,
    Document.GetElementById("root")
);