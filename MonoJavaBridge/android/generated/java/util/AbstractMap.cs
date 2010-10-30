namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractMap_))]
	public abstract partial class AbstractMap : java.lang.Object, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.AbstractMap._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.AbstractMap._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractMap.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.AbstractMap._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.AbstractMap.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.AbstractMap._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.AbstractMap.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.AbstractMap._m4) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractMap.staticClass, "hashCode", "()I", ref global::java.util.AbstractMap._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractMap.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.AbstractMap._m6) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractMap.staticClass, "clear", "()V", ref global::java.util.AbstractMap._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractMap.staticClass, "isEmpty", "()Z", ref global::java.util.AbstractMap._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractMap.staticClass, "size", "()I", ref global::java.util.AbstractMap._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract global::java.util.Set entrySet();
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractMap.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.AbstractMap._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.AbstractMap._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.AbstractMap.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.AbstractMap._m13) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.AbstractMap._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.AbstractMap._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected AbstractMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractMap._m16.native == global::System.IntPtr.Zero)
				global::java.util.AbstractMap._m16 = @__env.GetMethodIDNoThrow(global::java.util.AbstractMap.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractMap.staticClass, global::java.util.AbstractMap._m16);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.AbstractMap_.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.AbstractMap_._m0) as java.util.Set;
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
