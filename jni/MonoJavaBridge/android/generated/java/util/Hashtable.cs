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
		internal static global::MonoJavaBridge.MethodId _get26151;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._get26151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._get26151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26152;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._put26152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._put26152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26153;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._equals26153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._equals26153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26154;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._toString26154)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._toString26154)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _values26155;
		public virtual global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._values26155)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._values26155)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26156;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Hashtable._hashCode26156);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._hashCode26156);
		}
		internal static global::MonoJavaBridge.MethodId _clone26157;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._clone26157)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._clone26157)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26158;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Hashtable._clear26158);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._clear26158);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26159;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._isEmpty26159);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._isEmpty26159);
		}
		internal static global::MonoJavaBridge.MethodId _contains26160;
		public virtual bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._contains26160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._contains26160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26161;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Hashtable._size26161);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._size26161);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26162;
		public virtual global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._entrySet26162)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._entrySet26162)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26163;
		public virtual void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Hashtable._putAll26163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._putAll26163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26164;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._remove26164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._remove26164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements26165;
		public override global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._elements26165)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._elements26165)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys26166;
		public override global::java.util.Enumeration keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._keys26166)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._keys26166)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26167;
		public virtual global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Hashtable._keySet26167)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._keySet26167)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26168;
		public virtual bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._containsValue26168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._containsValue26168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26169;
		public virtual bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Hashtable._containsKey26169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._containsKey26169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rehash26170;
		protected virtual void rehash() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Hashtable._rehash26170);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Hashtable.staticClass, global::java.util.Hashtable._rehash26170);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26171;
		public Hashtable(int arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26172;
		public Hashtable(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26173;
		public Hashtable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26173);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Hashtable26174;
		public Hashtable(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Hashtable.staticClass, global::java.util.Hashtable._Hashtable26174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Hashtable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Hashtable"));
			global::java.util.Hashtable._get26151 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Hashtable._put26152 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Hashtable._equals26153 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._toString26154 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Hashtable._values26155 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.Hashtable._hashCode26156 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "hashCode", "()I");
			global::java.util.Hashtable._clone26157 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Hashtable._clear26158 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "clear", "()V");
			global::java.util.Hashtable._isEmpty26159 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "isEmpty", "()Z");
			global::java.util.Hashtable._contains26160 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._size26161 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "size", "()I");
			global::java.util.Hashtable._entrySet26162 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.Hashtable._putAll26163 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.Hashtable._remove26164 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Hashtable._elements26165 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Hashtable._keys26166 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.util.Hashtable._keySet26167 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.Hashtable._containsValue26168 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._containsKey26169 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.Hashtable._rehash26170 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "rehash", "()V");
			global::java.util.Hashtable._Hashtable26171 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(IF)V");
			global::java.util.Hashtable._Hashtable26172 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(I)V");
			global::java.util.Hashtable._Hashtable26173 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "()V");
			global::java.util.Hashtable._Hashtable26174 = @__env.GetMethodIDNoThrow(global::java.util.Hashtable.staticClass, "<init>", "(Ljava/util/Map;)V");
		}
	}
}
