namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Attributes : java.lang.Object, Map, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Attributes(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Name : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Name(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override bool equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.jar.Attributes.Name.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.jar.Attributes.Name._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.jar.Attributes.Name.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.jar.Attributes.Name._m1) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public override int hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.jar.Attributes.Name.staticClass, "hashCode", "()I", ref global::java.util.jar.Attributes.Name._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public Name(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.jar.Attributes.Name._m3.native == global::System.IntPtr.Zero)
					global::java.util.jar.Attributes.Name._m3 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _MANIFEST_VERSION6837;
			public static global::java.util.jar.Attributes.Name MANIFEST_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _MANIFEST_VERSION6837)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SIGNATURE_VERSION6838;
			public static global::java.util.jar.Attributes.Name SIGNATURE_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SIGNATURE_VERSION6838)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_TYPE6839;
			public static global::java.util.jar.Attributes.Name CONTENT_TYPE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _CONTENT_TYPE6839)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_PATH6840;
			public static global::java.util.jar.Attributes.Name CLASS_PATH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _CLASS_PATH6840)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MAIN_CLASS6841;
			public static global::java.util.jar.Attributes.Name MAIN_CLASS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _MAIN_CLASS6841)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SEALED6842;
			public static global::java.util.jar.Attributes.Name SEALED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SEALED6842)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_LIST6843;
			public static global::java.util.jar.Attributes.Name EXTENSION_LIST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _EXTENSION_LIST6843)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_NAME6844;
			public static global::java.util.jar.Attributes.Name EXTENSION_NAME
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _EXTENSION_NAME6844)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_INSTALLATION6845;
			public static global::java.util.jar.Attributes.Name EXTENSION_INSTALLATION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _EXTENSION_INSTALLATION6845)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_TITLE6846;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_TITLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_TITLE6846)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VERSION6847;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_VERSION6847)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VENDOR6848;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VENDOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_VENDOR6848)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VENDOR_ID6849;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VENDOR_ID
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_VENDOR_ID6849)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_URL6850;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_URL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_URL6850)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_TITLE6851;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_TITLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SPECIFICATION_TITLE6851)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_VERSION6852;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SPECIFICATION_VERSION6852)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_VENDOR6853;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_VENDOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SPECIFICATION_VENDOR6853)) as java.util.jar.Attributes.Name;
				}
			}
			static Name()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.jar.Attributes.Name.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Attributes$Name"));
				global::java.util.jar.Attributes.Name._MANIFEST_VERSION6837 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "MANIFEST_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SIGNATURE_VERSION6838 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SIGNATURE_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._CONTENT_TYPE6839 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "CONTENT_TYPE", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._CLASS_PATH6840 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "CLASS_PATH", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._MAIN_CLASS6841 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "MAIN_CLASS", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SEALED6842 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SEALED", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._EXTENSION_LIST6843 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "EXTENSION_LIST", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._EXTENSION_NAME6844 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "EXTENSION_NAME", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._EXTENSION_INSTALLATION6845 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "EXTENSION_INSTALLATION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_TITLE6846 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_TITLE", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_VERSION6847 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_VENDOR6848 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_VENDOR", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_VENDOR_ID6849 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_VENDOR_ID", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_URL6850 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_URL", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SPECIFICATION_TITLE6851 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SPECIFICATION_TITLE", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SPECIFICATION_VERSION6852 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SPECIFICATION_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SPECIFICATION_VENDOR6853 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SPECIFICATION_VENDOR", "Ljava/util/jar/Attributes$Name;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.Attributes.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.jar.Attributes._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.Attributes.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.jar.Attributes._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.jar.Attributes.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.jar.Attributes._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.jar.Attributes.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.jar.Attributes._m3) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.jar.Attributes.staticClass, "hashCode", "()I", ref global::java.util.jar.Attributes._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.Attributes.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.jar.Attributes._m5) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Attributes.staticClass, "clear", "()V", ref global::java.util.jar.Attributes._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.jar.Attributes.staticClass, "isEmpty", "()Z", ref global::java.util.jar.Attributes._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String getValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.jar.Attributes.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.jar.Attributes._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getValue(java.util.jar.Attributes.Name arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.jar.Attributes.staticClass, "getValue", "(Ljava/util/jar/Attributes$Name;)Ljava/lang/String;", ref global::java.util.jar.Attributes._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.jar.Attributes.staticClass, "size", "()I", ref global::java.util.jar.Attributes._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.jar.Attributes.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.jar.Attributes._m11) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Attributes.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.jar.Attributes._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.Attributes.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.jar.Attributes._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.jar.Attributes.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.jar.Attributes._m14) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.jar.Attributes.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.jar.Attributes._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.jar.Attributes.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.jar.Attributes._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.String putValue(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.jar.Attributes.staticClass, "putValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.jar.Attributes._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public Attributes(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.Attributes._m18.native == global::System.IntPtr.Zero)
				global::java.util.jar.Attributes._m18 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public Attributes(java.util.jar.Attributes arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.Attributes._m19.native == global::System.IntPtr.Zero)
				global::java.util.jar.Attributes._m19 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "(Ljava/util/jar/Attributes;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public Attributes() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.Attributes._m20.native == global::System.IntPtr.Zero)
				global::java.util.jar.Attributes._m20 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._m20);
			Init(@__env, handle);
		}
		static Attributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.Attributes.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Attributes"));
		}
	}
}
