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
		internal static global::MonoJavaBridge.MethodId _get26762;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._get26762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._get26762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26763;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._put26763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._put26763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _values26764;
		public override global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._values26764)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._values26764)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clone26765;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._clone26765)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._clone26765)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26766;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TreeMap._clear26766);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._clear26766);
		}
		internal static global::MonoJavaBridge.MethodId _size26767;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TreeMap._size26767);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._size26767);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26768;
		public override global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._entrySet26768)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._entrySet26768)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26769;
		public override void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TreeMap._putAll26769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._putAll26769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26770;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._remove26770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._remove26770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26771;
		public override global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._keySet26771)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._keySet26771)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26772;
		public override bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeMap._containsValue26772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._containsValue26772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26773;
		public override bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TreeMap._containsKey26773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._containsKey26773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comparator26774;
		public virtual global::java.util.Comparator comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._comparator26774)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._comparator26774)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subMap26775;
		public virtual global::java.util.SortedMap subMap(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._subMap26775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._subMap26775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _headMap26776;
		public virtual global::java.util.SortedMap headMap(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._headMap26776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._headMap26776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _tailMap26777;
		public virtual global::java.util.SortedMap tailMap(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._tailMap26777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._tailMap26777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _firstKey26778;
		public virtual global::java.lang.Object firstKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._firstKey26778)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._firstKey26778)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _lastKey26779;
		public virtual global::java.lang.Object lastKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._lastKey26779)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lastKey26779)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _firstEntry26780;
		public virtual global::java.util.Map_Entry firstEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._firstEntry26780)) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._firstEntry26780)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _lastEntry26781;
		public virtual global::java.util.Map_Entry lastEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._lastEntry26781)) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lastEntry26781)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _pollFirstEntry26782;
		public virtual global::java.util.Map_Entry pollFirstEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._pollFirstEntry26782)) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._pollFirstEntry26782)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _pollLastEntry26783;
		public virtual global::java.util.Map_Entry pollLastEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._pollLastEntry26783)) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._pollLastEntry26783)) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _lowerEntry26784;
		public virtual global::java.util.Map_Entry lowerEntry(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._lowerEntry26784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lowerEntry26784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _lowerKey26785;
		public virtual global::java.lang.Object lowerKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._lowerKey26785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._lowerKey26785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _floorEntry26786;
		public virtual global::java.util.Map_Entry floorEntry(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._floorEntry26786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._floorEntry26786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _floorKey26787;
		public virtual global::java.lang.Object floorKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._floorKey26787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._floorKey26787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _ceilingEntry26788;
		public virtual global::java.util.Map_Entry ceilingEntry(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._ceilingEntry26788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._ceilingEntry26788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _ceilingKey26789;
		public virtual global::java.lang.Object ceilingKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._ceilingKey26789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._ceilingKey26789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _higherEntry26790;
		public virtual global::java.util.Map_Entry higherEntry(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._higherEntry26790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map_Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._higherEntry26790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map_Entry;
		}
		internal static global::MonoJavaBridge.MethodId _higherKey26791;
		public virtual global::java.lang.Object higherKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TreeMap._higherKey26791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TreeMap.staticClass, global::java.util.TreeMap._higherKey26791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap26792;
		public TreeMap(java.util.Comparator arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap26792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap26793;
		public TreeMap(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap26793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap26794;
		public TreeMap(java.util.SortedMap arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap26794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TreeMap26795;
		public TreeMap()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TreeMap.staticClass, global::java.util.TreeMap._TreeMap26795);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TreeMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TreeMap"));
			global::java.util.TreeMap._get26762 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._put26763 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._values26764 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.TreeMap._clone26765 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.TreeMap._clear26766 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "clear", "()V");
			global::java.util.TreeMap._size26767 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "size", "()I");
			global::java.util.TreeMap._entrySet26768 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.TreeMap._putAll26769 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.TreeMap._remove26770 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._keySet26771 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.TreeMap._containsValue26772 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.TreeMap._containsKey26773 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.TreeMap._comparator26774 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.TreeMap._subMap26775 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.TreeMap._headMap26776 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.TreeMap._tailMap26777 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.TreeMap._firstKey26778 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "firstKey", "()Ljava/lang/Object;");
			global::java.util.TreeMap._lastKey26779 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lastKey", "()Ljava/lang/Object;");
			global::java.util.TreeMap._firstEntry26780 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "firstEntry", "()Ljava/util/Map$Entry;");
			global::java.util.TreeMap._lastEntry26781 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lastEntry", "()Ljava/util/Map$Entry;");
			global::java.util.TreeMap._pollFirstEntry26782 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "pollFirstEntry", "()Ljava/util/Map$Entry;");
			global::java.util.TreeMap._pollLastEntry26783 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "pollLastEntry", "()Ljava/util/Map$Entry;");
			global::java.util.TreeMap._lowerEntry26784 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			global::java.util.TreeMap._lowerKey26785 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._floorEntry26786 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			global::java.util.TreeMap._floorKey26787 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._ceilingEntry26788 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			global::java.util.TreeMap._ceilingKey26789 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._higherEntry26790 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;");
			global::java.util.TreeMap._higherKey26791 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.TreeMap._TreeMap26792 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/Comparator;)V");
			global::java.util.TreeMap._TreeMap26793 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::java.util.TreeMap._TreeMap26794 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "(Ljava/util/SortedMap;)V");
			global::java.util.TreeMap._TreeMap26795 = @__env.GetMethodIDNoThrow(global::java.util.TreeMap.staticClass, "<init>", "()V");
		}
	}
}
