namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TreeMap : java.util.AbstractMap, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TreeMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26881;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._get26881.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._get26881 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._get26881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26882;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._put26882.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._put26882 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._put26882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _values26883;
		public override global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._values26883.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._values26883 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "values", "()Ljava/util/Collection;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._values26883) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clone26884;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._clone26884.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._clone26884 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._clone26884) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26885;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._clear26885.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._clear26885 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "clear", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._clear26885);
		}
		internal static global::MonoJavaBridge.MethodId _size26886;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._size26886.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._size26886 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "size", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._size26886);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26887;
		public override global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._entrySet26887.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._entrySet26887 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "entrySet", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._entrySet26887) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26888;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._putAll26888.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._putAll26888 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._putAll26888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26889;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._remove26889.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._remove26889 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._remove26889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26890;
		public override global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._keySet26890.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._keySet26890 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "keySet", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._keySet26890) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26891;
		public override bool containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._containsValue26891.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._containsValue26891 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._containsValue26891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26892;
		public override bool containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._containsKey26892.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._containsKey26892 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._containsKey26892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comparator26893;
		public virtual global::java.util.Comparator comparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._comparator26893.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._comparator26893 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "comparator", "()Ljava/util/Comparator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Comparator>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._comparator26893) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subMap26894;
		public virtual global::java.util.SortedMap subMap(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._subMap26894.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._subMap26894 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._subMap26894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _headMap26895;
		public virtual global::java.util.SortedMap headMap(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._headMap26895.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._headMap26895 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._headMap26895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _tailMap26896;
		public virtual global::java.util.SortedMap tailMap(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._tailMap26896.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._tailMap26896 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._tailMap26896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _firstKey26897;
		public virtual global::java.lang.Object firstKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._firstKey26897.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._firstKey26897 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "firstKey", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._firstKey26897) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastKey26898;
		public virtual global::java.lang.Object lastKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._lastKey26898.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._lastKey26898 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lastKey", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lastKey26898) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _firstEntry26899;
		public virtual global::java.util.Map_Entry firstEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._firstEntry26899.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._firstEntry26899 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "firstEntry", "()Ljava/util/Map$Entry;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._firstEntry26899) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _lastEntry26900;
		public virtual global::java.util.Map_Entry lastEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._lastEntry26900.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._lastEntry26900 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lastEntry", "()Ljava/util/Map$Entry;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lastEntry26900) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _pollFirstEntry26901;
		public virtual global::java.util.Map_Entry pollFirstEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._pollFirstEntry26901.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._pollFirstEntry26901 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "pollFirstEntry", "()Ljava/util/Map$Entry;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._pollFirstEntry26901) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _pollLastEntry26902;
		public virtual global::java.util.Map_Entry pollLastEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._pollLastEntry26902.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._pollLastEntry26902 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "pollLastEntry", "()Ljava/util/Map$Entry;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._pollLastEntry26902) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _lowerEntry26903;
		public virtual global::java.util.Map_Entry lowerEntry(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._lowerEntry26903.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._lowerEntry26903 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lowerEntry26903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _lowerKey26904;
		public virtual global::java.lang.Object lowerKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._lowerKey26904.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._lowerKey26904 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lowerKey26904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _floorEntry26905;
		public virtual global::java.util.Map_Entry floorEntry(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._floorEntry26905.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._floorEntry26905 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._floorEntry26905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _floorKey26906;
		public virtual global::java.lang.Object floorKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._floorKey26906.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._floorKey26906 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._floorKey26906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _ceilingEntry26907;
		public virtual global::java.util.Map_Entry ceilingEntry(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._ceilingEntry26907.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._ceilingEntry26907 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._ceilingEntry26907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _ceilingKey26908;
		public virtual global::java.lang.Object ceilingKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._ceilingKey26908.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._ceilingKey26908 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._ceilingKey26908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _higherEntry26909;
		public virtual global::java.util.Map_Entry higherEntry(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._higherEntry26909.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._higherEntry26909 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._higherEntry26909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _higherKey26910;
		public virtual global::java.lang.Object higherKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._higherKey26910.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._higherKey26910 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._higherKey26910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap26911;
		public TreeMap(java.util.Comparator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._TreeMap26911.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._TreeMap26911 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/Comparator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap26911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap26912;
		public TreeMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._TreeMap26912.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._TreeMap26912 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap26912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap26913;
		public TreeMap(java.util.SortedMap arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._TreeMap26913.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._TreeMap26913 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/SortedMap;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap26913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap26914;
		public TreeMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._TreeMap26914.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._TreeMap26914 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap26914);
			Init(@__env, handle);
		}
		static TreeMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TreeMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TreeMap"));
		}
		internal static void InitJNI()
		{
		}
	}
}
