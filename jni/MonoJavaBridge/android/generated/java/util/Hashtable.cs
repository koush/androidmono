namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Hashtable : java.util.Dictionary, Map, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Hashtable()
		{
			InitJNI();
		}
		protected Hashtable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26269;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._get26269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._get26269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26270;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._put26270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._put26270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26271;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._equals26271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._equals26271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26272;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._toString26272)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._toString26272)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _values26273;
		public virtual global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._values26273)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._values26273)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26274;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Hashtable._hashCode26274);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._hashCode26274);
		}
		internal static global::MonoJavaBridge.MethodId _clone26275;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._clone26275)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._clone26275)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26276;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Hashtable._clear26276);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._clear26276);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26277;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._isEmpty26277);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._isEmpty26277);
		}
		internal static global::MonoJavaBridge.MethodId _contains26278;
		public virtual bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._contains26278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._contains26278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26279;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Hashtable._size26279);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._size26279);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26280;
		public virtual global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._entrySet26280)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._entrySet26280)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26281;
		public virtual void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Hashtable._putAll26281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._putAll26281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26282;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._remove26282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._remove26282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements26283;
		public override global::java.util.Enumeration elements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._elements26283)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._elements26283)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys26284;
		public override global::java.util.Enumeration keys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._keys26284)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._keys26284)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26285;
		public virtual global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._keySet26285)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._keySet26285)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26286;
		public virtual bool containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._containsValue26286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._containsValue26286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26287;
		public virtual bool containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._containsKey26287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._containsKey26287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rehash26288;
		protected virtual void rehash()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Hashtable._rehash26288);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._rehash26288);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26289;
		public Hashtable(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26290;
		public Hashtable(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26291;
		public Hashtable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26291);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26292;
		public Hashtable(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Hashtable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Hashtable"));
			global::java.util.Hashtable._get26269 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Hashtable._put26270 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Hashtable._equals26271 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._toString26272 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Hashtable._values26273 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.Hashtable._hashCode26274 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "hashCode", "()I");
			global::java.util.Hashtable._clone26275 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Hashtable._clear26276 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "clear", "()V");
			global::java.util.Hashtable._isEmpty26277 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "isEmpty", "()Z");
			global::java.util.Hashtable._contains26278 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._size26279 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "size", "()I");
			global::java.util.Hashtable._entrySet26280 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.Hashtable._putAll26281 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.Hashtable._remove26282 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Hashtable._elements26283 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Hashtable._keys26284 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.util.Hashtable._keySet26285 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.Hashtable._containsValue26286 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._containsKey26287 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._rehash26288 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "rehash", "()V");
			global::java.util.Hashtable._Hashtable26289 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(IF)V");
			global::java.util.Hashtable._Hashtable26290 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(I)V");
			global::java.util.Hashtable._Hashtable26291 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "()V");
			global::java.util.Hashtable._Hashtable26292 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(Ljava/util/Map;)V");
		}
	}
}
