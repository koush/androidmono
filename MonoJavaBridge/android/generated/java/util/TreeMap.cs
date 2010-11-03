namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TreeMap : java.util.AbstractMap, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TreeMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.TreeMap._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.TreeMap._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.TreeMap.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.TreeMap._m2) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.TreeMap._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.TreeMap.staticClass, "clear", "()V", ref global::java.util.TreeMap._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.TreeMap.staticClass, "size", "()I", ref global::java.util.TreeMap._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.TreeMap.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.TreeMap._m6) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.TreeMap.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.TreeMap._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.TreeMap._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.TreeMap.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.TreeMap._m9) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.TreeMap._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TreeMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.TreeMap._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.util.Comparator comparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Comparator>(this, global::java.util.TreeMap.staticClass, "comparator", "()Ljava/util/Comparator;", ref global::java.util.TreeMap._m12) as java.util.Comparator;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.util.SortedMap subMap(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.TreeMap.staticClass, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", ref global::java.util.TreeMap._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.SortedMap;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.util.SortedMap headMap(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.TreeMap.staticClass, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", ref global::java.util.TreeMap._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedMap;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.util.SortedMap tailMap(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.TreeMap.staticClass, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", ref global::java.util.TreeMap._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.SortedMap;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.Object firstKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, "firstKey", "()Ljava/lang/Object;", ref global::java.util.TreeMap._m16) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.Object lastKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, "lastKey", "()Ljava/lang/Object;", ref global::java.util.TreeMap._m17) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.util.Map_Entry firstEntry()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, "firstEntry", "()Ljava/util/Map$Entry;", ref global::java.util.TreeMap._m18) as java.util.Map_Entry;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.util.Map_Entry lastEntry()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, "lastEntry", "()Ljava/util/Map$Entry;", ref global::java.util.TreeMap._m19) as java.util.Map_Entry;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.util.Map_Entry pollFirstEntry()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, "pollFirstEntry", "()Ljava/util/Map$Entry;", ref global::java.util.TreeMap._m20) as java.util.Map_Entry;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.util.Map_Entry pollLastEntry()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, "pollLastEntry", "()Ljava/util/Map$Entry;", ref global::java.util.TreeMap._m21) as java.util.Map_Entry;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::java.util.Map_Entry lowerEntry(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, "lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", ref global::java.util.TreeMap._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Map_Entry;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.lang.Object lowerKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, "lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.TreeMap._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual global::java.util.Map_Entry floorEntry(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, "floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", ref global::java.util.TreeMap._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Map_Entry;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.lang.Object floorKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, "floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.TreeMap._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.util.Map_Entry ceilingEntry(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, "ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", ref global::java.util.TreeMap._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Map_Entry;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::java.lang.Object ceilingKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, "ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.TreeMap._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::java.util.Map_Entry higherEntry(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map_Entry>(this, global::java.util.TreeMap.staticClass, "higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", ref global::java.util.TreeMap._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Map_Entry;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual global::java.lang.Object higherKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TreeMap.staticClass, "higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.TreeMap._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public TreeMap(java.util.Comparator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._m30.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._m30 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/Comparator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public TreeMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._m31.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._m31 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public TreeMap(java.util.SortedMap arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._m32.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._m32 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/SortedMap;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public TreeMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TreeMap._m33.native == global::System.IntPtr.Zero)
				global::java.util.TreeMap._m33 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._m33);
			Init(@__env, handle);
		}
		static TreeMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TreeMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TreeMap"));
		}
	}
}
