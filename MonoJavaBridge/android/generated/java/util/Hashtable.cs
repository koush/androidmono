namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Hashtable : java.util.Dictionary, Map, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Hashtable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Hashtable.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Hashtable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Hashtable.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Hashtable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Hashtable.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Hashtable._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Hashtable.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.Hashtable._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.Hashtable.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.Hashtable._m4) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Hashtable.staticClass, "hashCode", "()I", ref global::java.util.Hashtable._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Hashtable.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.Hashtable._m6) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Hashtable.staticClass, "clear", "()V", ref global::java.util.Hashtable._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Hashtable.staticClass, "isEmpty", "()Z", ref global::java.util.Hashtable._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Hashtable.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.Hashtable._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Hashtable.staticClass, "size", "()I", ref global::java.util.Hashtable._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.Hashtable.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.Hashtable._m11) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Hashtable.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.Hashtable._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Hashtable.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Hashtable._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::java.util.Enumeration elements()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.Hashtable.staticClass, "elements", "()Ljava/util/Enumeration;", ref global::java.util.Hashtable._m14) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::java.util.Enumeration keys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.Hashtable.staticClass, "keys", "()Ljava/util/Enumeration;", ref global::java.util.Hashtable._m15) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.Hashtable.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.Hashtable._m16) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Hashtable.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.Hashtable._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Hashtable.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.Hashtable._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected virtual void rehash()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Hashtable.staticClass, "rehash", "()V", ref global::java.util.Hashtable._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public Hashtable(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Hashtable._m20.native == global::System.IntPtr.Zero)
				global::java.util.Hashtable._m20 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public Hashtable(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Hashtable._m21.native == global::System.IntPtr.Zero)
				global::java.util.Hashtable._m21 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public Hashtable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Hashtable._m22.native == global::System.IntPtr.Zero)
				global::java.util.Hashtable._m22 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._m22);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public Hashtable(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Hashtable._m23.native == global::System.IntPtr.Zero)
				global::java.util.Hashtable._m23 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Hashtable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Hashtable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Hashtable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
