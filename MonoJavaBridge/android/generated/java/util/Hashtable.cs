namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Hashtable : java.util.Dictionary, Map, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Hashtable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26270;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Hashtable.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Hashtable._get26270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26271;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Hashtable.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Hashtable._put26271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26272;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Hashtable.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Hashtable._equals26272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26273;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Hashtable.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.Hashtable._toString26273) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _values26274;
		public virtual global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.Hashtable.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.Hashtable._values26274) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26275;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Hashtable.staticClass, "hashCode", "()I", ref global::java.util.Hashtable._hashCode26275);
		}
		internal static global::MonoJavaBridge.MethodId _clone26276;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Hashtable.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.Hashtable._clone26276) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26277;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Hashtable.staticClass, "clear", "()V", ref global::java.util.Hashtable._clear26277);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26278;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Hashtable.staticClass, "isEmpty", "()Z", ref global::java.util.Hashtable._isEmpty26278);
		}
		internal static global::MonoJavaBridge.MethodId _contains26279;
		public virtual bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Hashtable.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.Hashtable._contains26279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26280;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Hashtable.staticClass, "size", "()I", ref global::java.util.Hashtable._size26280);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26281;
		public virtual global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.Hashtable.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.Hashtable._entrySet26281) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26282;
		public virtual void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Hashtable.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.Hashtable._putAll26282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26283;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Hashtable.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Hashtable._remove26283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements26284;
		public override global::java.util.Enumeration elements()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.Hashtable.staticClass, "elements", "()Ljava/util/Enumeration;", ref global::java.util.Hashtable._elements26284) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys26285;
		public override global::java.util.Enumeration keys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.Hashtable.staticClass, "keys", "()Ljava/util/Enumeration;", ref global::java.util.Hashtable._keys26285) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26286;
		public virtual global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.Hashtable.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.Hashtable._keySet26286) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26287;
		public virtual bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Hashtable.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.Hashtable._containsValue26287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26288;
		public virtual bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Hashtable.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.Hashtable._containsKey26288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rehash26289;
		protected virtual void rehash()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Hashtable.staticClass, "rehash", "()V", ref global::java.util.Hashtable._rehash26289);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26290;
		public Hashtable(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Hashtable._Hashtable26290.native == global::System.IntPtr.Zero)
				global::java.util.Hashtable._Hashtable26290 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26291;
		public Hashtable(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Hashtable._Hashtable26291.native == global::System.IntPtr.Zero)
				global::java.util.Hashtable._Hashtable26291 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26292;
		public Hashtable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Hashtable._Hashtable26292.native == global::System.IntPtr.Zero)
				global::java.util.Hashtable._Hashtable26292 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26292);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26293;
		public Hashtable(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Hashtable._Hashtable26293.native == global::System.IntPtr.Zero)
				global::java.util.Hashtable._Hashtable26293 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
