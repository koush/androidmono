namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Attributes : java.lang.Object, Map, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Attributes()
		{
			InitJNI();
		}
		protected Attributes(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Name : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Name()
			{
				InitJNI();
			}
			protected Name(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _equals21866;
			public override bool equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.Name._equals21866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._equals21866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString21867;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.Name._toString21867)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._toString21867)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode21868;
			public override int hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.Attributes.Name._hashCode21868);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._hashCode21868);
			}
			internal static global::MonoJavaBridge.MethodId _Name21869;
			public Name(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._Name21869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _MANIFEST_VERSION21870;
			public static global::java.util.jar.Attributes.Name MANIFEST_VERSION
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SIGNATURE_VERSION21871;
			public static global::java.util.jar.Attributes.Name SIGNATURE_VERSION
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_TYPE21872;
			public static global::java.util.jar.Attributes.Name CONTENT_TYPE
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_PATH21873;
			public static global::java.util.jar.Attributes.Name CLASS_PATH
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MAIN_CLASS21874;
			public static global::java.util.jar.Attributes.Name MAIN_CLASS
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SEALED21875;
			public static global::java.util.jar.Attributes.Name SEALED
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_LIST21876;
			public static global::java.util.jar.Attributes.Name EXTENSION_LIST
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_NAME21877;
			public static global::java.util.jar.Attributes.Name EXTENSION_NAME
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_INSTALLATION21878;
			public static global::java.util.jar.Attributes.Name EXTENSION_INSTALLATION
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_TITLE21879;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_TITLE
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VERSION21880;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VERSION
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VENDOR21881;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VENDOR
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VENDOR_ID21882;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VENDOR_ID
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_URL21883;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_URL
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_TITLE21884;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_TITLE
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_VERSION21885;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_VERSION
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_VENDOR21886;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_VENDOR
			{
				get
				{
					return default(global::java.util.jar.Attributes.Name);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.jar.Attributes.Name.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Attributes$Name"));
				global::java.util.jar.Attributes.Name._equals21866 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::java.util.jar.Attributes.Name._toString21867 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "toString", "()Ljava/lang/String;");
				global::java.util.jar.Attributes.Name._hashCode21868 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "hashCode", "()I");
				global::java.util.jar.Attributes.Name._Name21869 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _get21887;
		public virtual global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._get21887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._get21887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put21888;
		public virtual global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._put21888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._put21888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals21889;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._equals21889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._equals21889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values21890;
		public virtual global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._values21890)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._values21890)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21891;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.Attributes._hashCode21891);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._hashCode21891);
		}
		internal static global::MonoJavaBridge.MethodId _clone21892;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._clone21892)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._clone21892)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear21893;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Attributes._clear21893);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._clear21893);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty21894;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._isEmpty21894);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._isEmpty21894);
		}
		internal static global::MonoJavaBridge.MethodId _getValue21895;
		public virtual global::java.lang.String getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._getValue21895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._getValue21895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue21896;
		public virtual global::java.lang.String getValue(java.util.jar.Attributes.Name arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._getValue21896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._getValue21896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size21897;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.Attributes._size21897);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._size21897);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet21898;
		public virtual global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._entrySet21898)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._entrySet21898)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll21899;
		public virtual void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Attributes._putAll21899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._putAll21899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove21900;
		public virtual global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._remove21900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._remove21900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet21901;
		public virtual global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._keySet21901)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._keySet21901)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue21902;
		public virtual bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._containsValue21902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._containsValue21902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey21903;
		public virtual bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._containsKey21903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._containsKey21903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putValue21904;
		public virtual global::java.lang.String putValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._putValue21904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._putValue21904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Attributes21905;
		public Attributes(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._Attributes21905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Attributes21906;
		public Attributes(java.util.jar.Attributes arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._Attributes21906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Attributes21907;
		public Attributes()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._Attributes21907);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.Attributes.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Attributes"));
			global::java.util.jar.Attributes._get21887 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.jar.Attributes._put21888 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.jar.Attributes._equals21889 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.jar.Attributes._values21890 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.jar.Attributes._hashCode21891 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "hashCode", "()I");
			global::java.util.jar.Attributes._clone21892 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.jar.Attributes._clear21893 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "clear", "()V");
			global::java.util.jar.Attributes._isEmpty21894 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "isEmpty", "()Z");
			global::java.util.jar.Attributes._getValue21895 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.jar.Attributes._getValue21896 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "getValue", "(Ljava/util/jar/Attributes$Name;)Ljava/lang/String;");
			global::java.util.jar.Attributes._size21897 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "size", "()I");
			global::java.util.jar.Attributes._entrySet21898 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.jar.Attributes._putAll21899 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.jar.Attributes._remove21900 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.jar.Attributes._keySet21901 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.jar.Attributes._containsValue21902 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.jar.Attributes._containsKey21903 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.jar.Attributes._putValue21904 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "putValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.jar.Attributes._Attributes21905 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "(I)V");
			global::java.util.jar.Attributes._Attributes21906 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "(Ljava/util/jar/Attributes;)V");
			global::java.util.jar.Attributes._Attributes21907 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "()V");
		}
	}
}
