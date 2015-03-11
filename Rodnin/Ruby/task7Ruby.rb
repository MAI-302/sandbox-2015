matrix = []
puts "Введите n:"
n = gets.to_i
puts "Введите m:"
m = gets.to_i
(0...n).each do |i|
	matrix[i] = Array.new(n.to_i){rand(10)-rand(10)}
end
0.upto(matrix.size - 1) { |i| p matrix[i] }
print "Минимальный из максимальных элементов строк: "
puts matrix.map{ |element| element.max }.min
