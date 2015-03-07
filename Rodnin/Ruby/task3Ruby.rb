require 'matrix'
mas = []
puts "Введите n:"
n = gets.chomp.to_i
(0...n).each do |i|
	mas[i] = []
	(0...n).each do |j|
		mas[i][j] = rand(100)-rand(100)
	end
	print mas[i]
	puts ""
end
print "Является ли матрица скалярной? - "
puts Matrix.scalar(mas.size, mas[0][0]) == Matrix[*mas]

