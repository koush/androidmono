namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Collections : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Collections()
		{
			InitJNI();
		}
		protected Collections(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _min26021;
		public static global::java.lang.Object min(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._min26021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _min26022;
		public static global::java.lang.Object min(java.util.Collection arg0, java.util.Comparator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._min26022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _max26023;
		public static global::java.lang.Object max(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._max26023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _max26024;
		public static global::java.lang.Object max(java.util.Collection arg0, java.util.Comparator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._max26024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _replaceAll26025;
		public static bool replaceAll(java.util.List arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._replaceAll26025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26026;
		public static bool addAll(java.util.Collection arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._addAll26026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _list26027;
		public static global::java.util.ArrayList list(java.util.Enumeration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._list26027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedSet26028;
		public static global::java.util.Set synchronizedSet(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedSet26028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedCollection26029;
		public static global::java.util.Collection synchronizedCollection(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedCollection26029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _copy26030;
		public static void copy(java.util.List arg0, java.util.List arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._copy26030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedList26031;
		public static global::java.util.List synchronizedList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedList26031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _reverse26032;
		public static void reverse(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._reverse26032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fill26033;
		public static void fill(java.util.List arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._fill26033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sort26034;
		public static void sort(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._sort26034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort26035;
		public static void sort(java.util.List arg0, java.util.Comparator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._sort26035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _swap26036;
		public static void swap(java.util.List arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._swap26036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch26037;
		public static int binarySearch(java.util.List arg0, java.lang.Object arg1, java.util.Comparator arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._binarySearch26037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch26038;
		public static int binarySearch(java.util.List arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._binarySearch26038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedMap26039;
		public static global::java.util.Map synchronizedMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedMap26039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _shuffle26040;
		public static void shuffle(java.util.List arg0, java.util.Random arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._shuffle26040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shuffle26041;
		public static void shuffle(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._shuffle26041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotate26042;
		public static void rotate(java.util.List arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._rotate26042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfSubList26043;
		public static int indexOfSubList(java.util.List arg0, java.util.List arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._indexOfSubList26043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOfSubList26044;
		public static int lastIndexOfSubList(java.util.List arg0, java.util.List arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._lastIndexOfSubList26044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableCollection26045;
		public static global::java.util.Collection unmodifiableCollection(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableCollection26045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableSet26046;
		public static global::java.util.Set unmodifiableSet(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableSet26046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableSortedSet26047;
		public static global::java.util.SortedSet unmodifiableSortedSet(java.util.SortedSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableSortedSet26047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableList26048;
		public static global::java.util.List unmodifiableList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableList26048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableMap26049;
		public static global::java.util.Map unmodifiableMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableMap26049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableSortedMap26050;
		public static global::java.util.SortedMap unmodifiableSortedMap(java.util.SortedMap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableSortedMap26050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedSortedSet26051;
		public static global::java.util.SortedSet synchronizedSortedSet(java.util.SortedSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedSortedSet26051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedSortedMap26052;
		public static global::java.util.SortedMap synchronizedSortedMap(java.util.SortedMap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedSortedMap26052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _checkedCollection26053;
		public static global::java.util.Collection checkedCollection(java.util.Collection arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedCollection26053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _checkedSet26054;
		public static global::java.util.Set checkedSet(java.util.Set arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedSet26054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _checkedSortedSet26055;
		public static global::java.util.SortedSet checkedSortedSet(java.util.SortedSet arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedSortedSet26055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _checkedList26056;
		public static global::java.util.List checkedList(java.util.List arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedList26056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _checkedMap26057;
		public static global::java.util.Map checkedMap(java.util.Map arg0, java.lang.Class arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedMap26057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _checkedSortedMap26058;
		public static global::java.util.SortedMap checkedSortedMap(java.util.SortedMap arg0, java.lang.Class arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedSortedMap26058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _emptySet26059;
		public static global::java.util.Set emptySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._emptySet26059)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _emptyList26060;
		public static global::java.util.List emptyList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._emptyList26060)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _emptyMap26061;
		public static global::java.util.Map emptyMap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._emptyMap26061)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _singleton26062;
		public static global::java.util.Set singleton(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._singleton26062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _singletonList26063;
		public static global::java.util.List singletonList(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._singletonList26063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _singletonMap26064;
		public static global::java.util.Map singletonMap(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._singletonMap26064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _nCopies26065;
		public static global::java.util.List nCopies(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._nCopies26065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _reverseOrder26066;
		public static global::java.util.Comparator reverseOrder(java.util.Comparator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._reverseOrder26066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _reverseOrder26067;
		public static global::java.util.Comparator reverseOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._reverseOrder26067)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _enumeration26068;
		public static global::java.util.Enumeration enumeration(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._enumeration26068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _frequency26069;
		public static int frequency(java.util.Collection arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._frequency26069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _disjoint26070;
		public static bool disjoint(java.util.Collection arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._disjoint26070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newSetFromMap26071;
		public static global::java.util.Set newSetFromMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._newSetFromMap26071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_SET26072;
		public static global::java.util.Set EMPTY_SET
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.GetStaticObjectField(global::java.util.Collections.staticClass, _EMPTY_SET26072)) as java.util.Set;
			}
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_LIST26073;
		public static global::java.util.List EMPTY_LIST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.GetStaticObjectField(global::java.util.Collections.staticClass, _EMPTY_LIST26073)) as java.util.List;
			}
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_MAP26074;
		public static global::java.util.Map EMPTY_MAP
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.GetStaticObjectField(global::java.util.Collections.staticClass, _EMPTY_MAP26074)) as java.util.Map;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Collections.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Collections"));
			global::java.util.Collections._min26021 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "min", "(Ljava/util/Collection;)Ljava/lang/Object;");
			global::java.util.Collections._min26022 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "min", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;");
			global::java.util.Collections._max26023 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "max", "(Ljava/util/Collection;)Ljava/lang/Object;");
			global::java.util.Collections._max26024 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "max", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;");
			global::java.util.Collections._replaceAll26025 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "replaceAll", "(Ljava/util/List;Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.Collections._addAll26026 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "addAll", "(Ljava/util/Collection;[Ljava/lang/Object;)Z");
			global::java.util.Collections._list26027 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "list", "(Ljava/util/Enumeration;)Ljava/util/ArrayList;");
			global::java.util.Collections._synchronizedSet26028 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSet", "(Ljava/util/Set;)Ljava/util/Set;");
			global::java.util.Collections._synchronizedCollection26029 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedCollection", "(Ljava/util/Collection;)Ljava/util/Collection;");
			global::java.util.Collections._copy26030 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "copy", "(Ljava/util/List;Ljava/util/List;)V");
			global::java.util.Collections._synchronizedList26031 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedList", "(Ljava/util/List;)Ljava/util/List;");
			global::java.util.Collections._reverse26032 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverse", "(Ljava/util/List;)V");
			global::java.util.Collections._fill26033 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "fill", "(Ljava/util/List;Ljava/lang/Object;)V");
			global::java.util.Collections._sort26034 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "sort", "(Ljava/util/List;)V");
			global::java.util.Collections._sort26035 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "sort", "(Ljava/util/List;Ljava/util/Comparator;)V");
			global::java.util.Collections._swap26036 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "swap", "(Ljava/util/List;II)V");
			global::java.util.Collections._binarySearch26037 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "binarySearch", "(Ljava/util/List;Ljava/lang/Object;Ljava/util/Comparator;)I");
			global::java.util.Collections._binarySearch26038 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "binarySearch", "(Ljava/util/List;Ljava/lang/Object;)I");
			global::java.util.Collections._synchronizedMap26039 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedMap", "(Ljava/util/Map;)Ljava/util/Map;");
			global::java.util.Collections._shuffle26040 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "shuffle", "(Ljava/util/List;Ljava/util/Random;)V");
			global::java.util.Collections._shuffle26041 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "shuffle", "(Ljava/util/List;)V");
			global::java.util.Collections._rotate26042 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "rotate", "(Ljava/util/List;I)V");
			global::java.util.Collections._indexOfSubList26043 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "indexOfSubList", "(Ljava/util/List;Ljava/util/List;)I");
			global::java.util.Collections._lastIndexOfSubList26044 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "lastIndexOfSubList", "(Ljava/util/List;Ljava/util/List;)I");
			global::java.util.Collections._unmodifiableCollection26045 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableCollection", "(Ljava/util/Collection;)Ljava/util/Collection;");
			global::java.util.Collections._unmodifiableSet26046 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSet", "(Ljava/util/Set;)Ljava/util/Set;");
			global::java.util.Collections._unmodifiableSortedSet26047 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;");
			global::java.util.Collections._unmodifiableList26048 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableList", "(Ljava/util/List;)Ljava/util/List;");
			global::java.util.Collections._unmodifiableMap26049 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableMap", "(Ljava/util/Map;)Ljava/util/Map;");
			global::java.util.Collections._unmodifiableSortedMap26050 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;");
			global::java.util.Collections._synchronizedSortedSet26051 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;");
			global::java.util.Collections._synchronizedSortedMap26052 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;");
			global::java.util.Collections._checkedCollection26053 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedCollection", "(Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;");
			global::java.util.Collections._checkedSet26054 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSet", "(Ljava/util/Set;Ljava/lang/Class;)Ljava/util/Set;");
			global::java.util.Collections._checkedSortedSet26055 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSortedSet", "(Ljava/util/SortedSet;Ljava/lang/Class;)Ljava/util/SortedSet;");
			global::java.util.Collections._checkedList26056 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedList", "(Ljava/util/List;Ljava/lang/Class;)Ljava/util/List;");
			global::java.util.Collections._checkedMap26057 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedMap", "(Ljava/util/Map;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/Map;");
			global::java.util.Collections._checkedSortedMap26058 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSortedMap", "(Ljava/util/SortedMap;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/SortedMap;");
			global::java.util.Collections._emptySet26059 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptySet", "()Ljava/util/Set;");
			global::java.util.Collections._emptyList26060 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptyList", "()Ljava/util/List;");
			global::java.util.Collections._emptyMap26061 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptyMap", "()Ljava/util/Map;");
			global::java.util.Collections._singleton26062 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singleton", "(Ljava/lang/Object;)Ljava/util/Set;");
			global::java.util.Collections._singletonList26063 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singletonList", "(Ljava/lang/Object;)Ljava/util/List;");
			global::java.util.Collections._singletonMap26064 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singletonMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;");
			global::java.util.Collections._nCopies26065 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "nCopies", "(ILjava/lang/Object;)Ljava/util/List;");
			global::java.util.Collections._reverseOrder26066 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverseOrder", "(Ljava/util/Comparator;)Ljava/util/Comparator;");
			global::java.util.Collections._reverseOrder26067 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverseOrder", "()Ljava/util/Comparator;");
			global::java.util.Collections._enumeration26068 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "enumeration", "(Ljava/util/Collection;)Ljava/util/Enumeration;");
			global::java.util.Collections._frequency26069 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "frequency", "(Ljava/util/Collection;Ljava/lang/Object;)I");
			global::java.util.Collections._disjoint26070 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "disjoint", "(Ljava/util/Collection;Ljava/util/Collection;)Z");
			global::java.util.Collections._newSetFromMap26071 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "newSetFromMap", "(Ljava/util/Map;)Ljava/util/Set;");
			global::java.util.Collections._EMPTY_SET26072 = @__env.GetStaticFieldIDNoThrow(global::java.util.Collections.staticClass, "EMPTY_SET", "Ljava/util/Set;");
			global::java.util.Collections._EMPTY_LIST26073 = @__env.GetStaticFieldIDNoThrow(global::java.util.Collections.staticClass, "EMPTY_LIST", "Ljava/util/List;");
			global::java.util.Collections._EMPTY_MAP26074 = @__env.GetStaticFieldIDNoThrow(global::java.util.Collections.staticClass, "EMPTY_MAP", "Ljava/util/Map;");
		}
	}
}
