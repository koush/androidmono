namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TreeMap : java.util.AbstractMap, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TreeMap()
		{
			InitJNI();
		}
		protected TreeMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get20932;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._get20932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._get20932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put20933;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._put20933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._put20933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _values20934;
		public override global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._values20934)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._values20934)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clone20935;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._clone20935)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._clone20935)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear20936;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TreeMap._clear20936);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._clear20936);
		}
		internal static global::MonoJavaBridge.MethodId _size20937;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TreeMap._size20937);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._size20937);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet20938;
		public override global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._entrySet20938)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._entrySet20938)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll20939;
		public override void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TreeMap._putAll20939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._putAll20939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove20940;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._remove20940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._remove20940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet20941;
		public override global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._keySet20941)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._keySet20941)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue20942;
		public override bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeMap._containsValue20942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._containsValue20942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey20943;
		public override bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeMap._containsKey20943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._containsKey20943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comparator20944;
		public virtual global::java.util.Comparator comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._comparator20944)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._comparator20944)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subMap20945;
		public virtual global::java.util.SortedMap subMap(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._subMap20945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._subMap20945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _headMap20946;
		public virtual global::java.util.SortedMap headMap(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._headMap20946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._headMap20946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _tailMap20947;
		public virtual global::java.util.SortedMap tailMap(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._tailMap20947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._tailMap20947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _firstKey20948;
		public virtual global::java.lang.Object firstKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._firstKey20948)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._firstKey20948)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastKey20949;
		public virtual global::java.lang.Object lastKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._lastKey20949)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lastKey20949)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _firstEntry20950;
		public virtual global::java.util.Map_Entry firstEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._firstEntry20950)) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._firstEntry20950)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _lastEntry20951;
		public virtual global::java.util.Map_Entry lastEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._lastEntry20951)) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lastEntry20951)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _pollFirstEntry20952;
		public virtual global::java.util.Map_Entry pollFirstEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._pollFirstEntry20952)) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._pollFirstEntry20952)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _pollLastEntry20953;
		public virtual global::java.util.Map_Entry pollLastEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._pollLastEntry20953)) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._pollLastEntry20953)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _lowerEntry20954;
		public virtual global::java.util.Map_Entry lowerEntry(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._lowerEntry20954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lowerEntry20954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _lowerKey20955;
		public virtual global::java.lang.Object lowerKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._lowerKey20955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lowerKey20955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _floorEntry20956;
		public virtual global::java.util.Map_Entry floorEntry(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._floorEntry20956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._floorEntry20956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _floorKey20957;
		public virtual global::java.lang.Object floorKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._floorKey20957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._floorKey20957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _ceilingEntry20958;
		public virtual global::java.util.Map_Entry ceilingEntry(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._ceilingEntry20958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._ceilingEntry20958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _ceilingKey20959;
		public virtual global::java.lang.Object ceilingKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._ceilingKey20959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._ceilingKey20959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _higherEntry20960;
		public virtual global::java.util.Map_Entry higherEntry(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._higherEntry20960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._higherEntry20960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _higherKey20961;
		public virtual global::java.lang.Object higherKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._higherKey20961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._higherKey20961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap20962;
		public TreeMap(java.util.Comparator arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap20962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap20963;
		public TreeMap(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap20963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap20964;
		public TreeMap(java.util.SortedMap arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap20964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap20965;
		public TreeMap()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap20965);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TreeMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TreeMap"));
			global::java.util.TreeMap._get20932 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._put20933 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._values20934 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.TreeMap._clone20935 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.TreeMap._clear20936 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "clear", "()V");
			global::java.util.TreeMap._size20937 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "size", "()I");
			global::java.util.TreeMap._entrySet20938 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.TreeMap._putAll20939 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.TreeMap._remove20940 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._keySet20941 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.TreeMap._containsValue20942 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.TreeMap._containsKey20943 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.TreeMap._comparator20944 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.TreeMap._subMap20945 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.TreeMap._headMap20946 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.TreeMap._tailMap20947 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.TreeMap._firstKey20948 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "firstKey", "()Ljava/lang/Object;");
			global::java.util.TreeMap._lastKey20949 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lastKey", "()Ljava/lang/Object;");
			global::java.util.TreeMap._firstEntry20950 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "firstEntry", "()Ljava/util/Map$Entry;");
			global::java.util.TreeMap._lastEntry20951 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lastEntry", "()Ljava/util/Map$Entry;");
			global::java.util.TreeMap._pollFirstEntry20952 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "pollFirstEntry", "()Ljava/util/Map$Entry;");
			global::java.util.TreeMap._pollLastEntry20953 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "pollLastEntry", "()Ljava/util/Map$Entry;");
			global::java.util.TreeMap._lowerEntry20954 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			global::java.util.TreeMap._lowerKey20955 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._floorEntry20956 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			global::java.util.TreeMap._floorKey20957 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._ceilingEntry20958 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			global::java.util.TreeMap._ceilingKey20959 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._higherEntry20960 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			global::java.util.TreeMap._higherKey20961 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._TreeMap20962 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/Comparator;)V");
			global::java.util.TreeMap._TreeMap20963 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::java.util.TreeMap._TreeMap20964 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/SortedMap;)V");
			global::java.util.TreeMap._TreeMap20965 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "()V");
		}
	}
}
