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
		internal static global::MonoJavaBridge.MethodId _get20326;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._get20326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._get20326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put20327;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._put20327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._put20327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals20328;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._equals20328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._equals20328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20329;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._toString20329)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._toString20329)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _values20330;
		public virtual global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._values20330)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._values20330)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20331;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Hashtable._hashCode20331);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._hashCode20331);
		}
		internal static global::MonoJavaBridge.MethodId _clone20332;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._clone20332)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._clone20332)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear20333;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Hashtable._clear20333);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._clear20333);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20334;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._isEmpty20334);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._isEmpty20334);
		}
		internal static global::MonoJavaBridge.MethodId _contains20335;
		public virtual bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._contains20335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._contains20335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size20336;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Hashtable._size20336);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._size20336);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet20337;
		public virtual global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._entrySet20337)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._entrySet20337)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll20338;
		public virtual void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Hashtable._putAll20338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._putAll20338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove20339;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._remove20339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._remove20339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements20340;
		public override global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._elements20340)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._elements20340)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys20341;
		public override global::java.util.Enumeration keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._keys20341)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._keys20341)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keySet20342;
		public virtual global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._keySet20342)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._keySet20342)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue20343;
		public virtual bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._containsValue20343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._containsValue20343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey20344;
		public virtual bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._containsKey20344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._containsKey20344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rehash20345;
		protected virtual void rehash() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Hashtable._rehash20345);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._rehash20345);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable20346;
		public Hashtable(int arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable20346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable20347;
		public Hashtable(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable20347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable20348;
		public Hashtable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable20348);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable20349;
		public Hashtable(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable20349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Hashtable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Hashtable"));
			global::java.util.Hashtable._get20326 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Hashtable._put20327 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Hashtable._equals20328 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._toString20329 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Hashtable._values20330 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.Hashtable._hashCode20331 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "hashCode", "()I");
			global::java.util.Hashtable._clone20332 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Hashtable._clear20333 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "clear", "()V");
			global::java.util.Hashtable._isEmpty20334 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "isEmpty", "()Z");
			global::java.util.Hashtable._contains20335 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._size20336 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "size", "()I");
			global::java.util.Hashtable._entrySet20337 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.Hashtable._putAll20338 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.Hashtable._remove20339 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Hashtable._elements20340 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Hashtable._keys20341 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.util.Hashtable._keySet20342 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.Hashtable._containsValue20343 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._containsKey20344 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._rehash20345 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "rehash", "()V");
			global::java.util.Hashtable._Hashtable20346 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(IF)V");
			global::java.util.Hashtable._Hashtable20347 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(I)V");
			global::java.util.Hashtable._Hashtable20348 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "()V");
			global::java.util.Hashtable._Hashtable20349 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(Ljava/util/Map;)V");
		}
	}
}
