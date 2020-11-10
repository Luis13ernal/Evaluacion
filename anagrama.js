function anagrama(a,b){
	const aAlfabetico = a.split('').sort().join('');
	const bAlfabetico = b.split('').sort().join('');

	return aAlfabetico == bAlfabetico;

}