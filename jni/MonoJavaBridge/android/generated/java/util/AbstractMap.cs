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
		internal static global::MonoJavaBridge.MethodId _get25699;
		public virtual global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._get25699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._get25699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put25700;
		public virtual global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._put25700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._put25700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals25701;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractMap._equals25701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._equals25701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25702;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._toString25702)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._toString25702)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _values25703;
		public virtual global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._values25703)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._values25703)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25704;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractMap._hashCode25704);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._hashCode25704);
		}
		internal static global::MonoJavaBridge.MethodId _clone25705;
		protected override global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._clone25705)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._clone25705)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear25706;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractMap._clear25706);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._clear25706);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty25707;
		public virtual bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractMap._isEmpty25707);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._isEmpty25707);
		}
		internal static global::MonoJavaBridge.MethodId _size25708;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractMap._size25708);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._size25708);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet25709;
		public abstract global::java.util.Set entrySet();
		internal static global::MonoJavaBridge.MethodId _putAll25710;
		public virtual void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractMap._putAll25710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._putAll25710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove25711;
		public virtual global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._remove25711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._remove25711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet25712;
		public virtual global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap._keySet25712)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._keySet25712)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue25713;
		public virtual bool containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractMap._containsValue25713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._containsValue25713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey25714;
		public virtual bool containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractMap._containsKey25714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._containsKey25714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractMap25715;
		protected AbstractMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractMap.staticClass, global::java.util.AbstractMap._AbstractMap25715);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractMap"));
			global::java.util.AbstractMap._get25699 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractMap._put25700 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractMap._equals25701 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractMap._toString25702 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.AbstractMap._values25703 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.AbstractMap._hashCode25704 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "hashCode", "()I");
			global::java.util.AbstractMap._clone25705 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.AbstractMap._clear25706 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "clear", "()V");
			global::java.util.AbstractMap._isEmpty25707 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "isEmpty", "()Z");
			global::java.util.AbstractMap._size25708 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "size", "()I");
			global::java.util.AbstractMap._entrySet25709 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.AbstractMap._putAll25710 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.AbstractMap._remove25711 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractMap._keySet25712 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.AbstractMap._containsValue25713 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractMap._containsKey25714 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractMap._AbstractMap25715 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractMap))]
	internal sealed partial class AbstractMap_ : java.util.AbstractMap
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractMap_()
		{
			InitJNI();
		}
		internal AbstractMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _entrySet25716;
		public override global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap_._entrySet25716)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractMap_.staticClass, global::java.util.AbstractMap_._entrySet25716)) as java.util.Set;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractMap"));
			global::java.util.AbstractMap_._entrySet25716 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap_.staticClass, "entrySet", "()Ljava/util/Set;");
		}
	}
}
