namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractMap_))]
	public abstract partial class AbstractMap : java.lang.Object, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractMap()
		{
			InitJNI();
		}
		protected AbstractMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get19805;
		public virtual global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._get19805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._get19805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put19806;
		public virtual global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._put19806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._put19806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals19807;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractMap._equals19807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._equals19807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19808;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._toString19808)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._toString19808)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _values19809;
		public virtual global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._values19809)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._values19809)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19810;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractMap._hashCode19810);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._hashCode19810);
		}
		internal static global::MonoJavaBridge.MethodId _clone19811;
		protected override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._clone19811)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._clone19811)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear19812;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractMap._clear19812);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._clear19812);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty19813;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractMap._isEmpty19813);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._isEmpty19813);
		}
		internal static global::MonoJavaBridge.MethodId _size19814;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractMap._size19814);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._size19814);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet19815;
		public abstract global::java.util.Set entrySet();
		internal static global::MonoJavaBridge.MethodId _putAll19816;
		public virtual void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractMap._putAll19816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._putAll19816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove19817;
		public virtual global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._remove19817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._remove19817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet19818;
		public virtual global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._keySet19818)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._keySet19818)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue19819;
		public virtual bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractMap._containsValue19819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._containsValue19819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey19820;
		public virtual bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractMap._containsKey19820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._containsKey19820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractMap19821;
		protected AbstractMap()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractMap.staticClass, global::java.util.AbstractMap._AbstractMap19821);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractMap"));
			global::java.util.AbstractMap._get19805 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractMap._put19806 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractMap._equals19807 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractMap._toString19808 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.AbstractMap._values19809 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.AbstractMap._hashCode19810 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "hashCode", "()I");
			global::java.util.AbstractMap._clone19811 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.AbstractMap._clear19812 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "clear", "()V");
			global::java.util.AbstractMap._isEmpty19813 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "isEmpty", "()Z");
			global::java.util.AbstractMap._size19814 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "size", "()I");
			global::java.util.AbstractMap._entrySet19815 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.AbstractMap._putAll19816 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.AbstractMap._remove19817 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractMap._keySet19818 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.AbstractMap._containsValue19819 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractMap._containsKey19820 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractMap._AbstractMap19821 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractMap))]
	public sealed partial class AbstractMap_ : java.util.AbstractMap
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractMap_()
		{
			InitJNI();
		}
		internal AbstractMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _entrySet19822;
		public override global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap_._entrySet19822)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap_.staticClass, global::java.util.AbstractMap_._entrySet19822)) as java.util.Set;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractMap"));
			global::java.util.AbstractMap_._entrySet19822 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap_.staticClass, "entrySet", "()Ljava/util/Set;");
		}
	}
}
