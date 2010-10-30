namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractMap_))]
	public abstract partial class AbstractMap : java.lang.Object, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get25700;
		public virtual global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._get25700.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._get25700 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._get25700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put25701;
		public virtual global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._put25701.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._put25701 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._put25701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals25702;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._equals25702.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._equals25702 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._equals25702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25703;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._toString25703.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._toString25703 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._toString25703) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _values25704;
		public virtual global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._values25704.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._values25704 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "values", "()Ljava/util/Collection;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._values25704) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25705;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._hashCode25705.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._hashCode25705 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._hashCode25705);
		}
		internal static global::MonoJavaBridge.MethodId _clone25706;
		protected override global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._clone25706.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._clone25706 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._clone25706) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear25707;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._clear25707.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._clear25707 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "clear", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._clear25707);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty25708;
		public virtual bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._isEmpty25708.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._isEmpty25708 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "isEmpty", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._isEmpty25708);
		}
		internal static global::MonoJavaBridge.MethodId _size25709;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._size25709.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._size25709 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "size", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._size25709);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet25710;
		public abstract global::java.util.Set entrySet();
		internal static global::MonoJavaBridge.MethodId _putAll25711;
		public virtual void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._putAll25711.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._putAll25711 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._putAll25711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove25712;
		public virtual global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._remove25712.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._remove25712 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._remove25712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet25713;
		public virtual global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._keySet25713.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._keySet25713 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "keySet", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._keySet25713) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue25714;
		public virtual bool containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._containsValue25714.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._containsValue25714 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._containsValue25714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey25715;
		public virtual bool containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._containsKey25715.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._containsKey25715 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._containsKey25715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractMap25716;
		protected AbstractMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._AbstractMap25716.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._AbstractMap25716 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractMap.staticClass, global::java.util.AbstractMap._AbstractMap25716);
			Init(@__env, handle);
		}
		static AbstractMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractMap"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractMap))]
	internal sealed partial class AbstractMap_ : java.util.AbstractMap
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _entrySet25717;
		public override global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap_._entrySet25717.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap_._entrySet25717 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap_.staticClass, "entrySet", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractMap_._entrySet25717)) as java.util.Set;
		}
		static AbstractMap_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractMap"));
		}
		internal static void InitJNI()
		{
		}
	}
}
