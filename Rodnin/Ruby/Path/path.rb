input = File.open("input.txt") {|file| file.read}
i = 0
input_array = []
input.split("\n").each do |str| 
	input_array[i] = str.split(' ').map! {|ch| ch.to_i}
    i += 1
end

i = j = input_array.count - 1
while i != 0 || j != 0 do
	input_array[i-1][j-1] = input_array[i-1][j-1] + [input_array[i][j], input_array[i][j-1]].max unless j.zero?
	j = j.zero? ? i = i - 1 : j - 1
end

path = [0]
level = 1
    path << input_array[level].index(input_array[level].max)
level = 2
while level < input_array.count do
      path << input_array[level].index([input_array[level][path[level-1]],input_array[level][path[level-1]+1]].max)
      level += 1
end


print "Максимальная сумма по оптимальному пути: "
puts input_array[0][0]
puts "Индексы оптимального пути:"
p path