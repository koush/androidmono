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
			internal static global::MonoJavaBridge.MethodId _equals27696;
			public override bool equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.Name._equals27696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._equals27696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString27697;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.Name._toString27697)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._toString27697)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode27698;
			public override int hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.Attributes.Name._hashCode27698);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._hashCode27698);
			}
			internal static global::MonoJavaBridge.MethodId _Name27699;
			public Name(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._Name27699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _MANIFEST_VERSION27700;
			public static global::java.util.jar.Attributes.Name MANIFEST_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _MANIFEST_VERSION27700)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SIGNATURE_VERSION27701;
			public static global::java.util.jar.Attributes.Name SIGNATURE_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SIGNATURE_VERSION27701)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_TYPE27702;
			public static global::java.util.jar.Attributes.Name CONTENT_TYPE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _CONTENT_TYPE27702)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_PATH27703;
			public static global::java.util.jar.Attributes.Name CLASS_PATH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _CLASS_PATH27703)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MAIN_CLASS27704;
			public static global::java.util.jar.Attributes.Name MAIN_CLASS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _MAIN_CLASS27704)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SEALED27705;
			public static global::java.util.jar.Attributes.Name SEALED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SEALED27705)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_LIST27706;
			public static global::java.util.jar.Attributes.Name EXTENSION_LIST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _EXTENSION_LIST27706)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_NAME27707;
			public static global::java.util.jar.Attributes.Name EXTENSION_NAME
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _EXTENSION_NAME27707)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_INSTALLATION27708;
			public static global::java.util.jar.Attributes.Name EXTENSION_INSTALLATION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _EXTENSION_INSTALLATION27708)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_TITLE27709;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_TITLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_TITLE27709)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VERSION27710;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_VERSION27710)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VENDOR27711;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VENDOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_VENDOR27711)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VENDOR_ID27712;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VENDOR_ID
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_VENDOR_ID27712)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_URL27713;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_URL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_URL27713)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_TITLE27714;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_TITLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SPECIFICATION_TITLE27714)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_VERSION27715;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SPECIFICATION_VERSION27715)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_VENDOR27716;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_VENDOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SPECIFICATION_VENDOR27716)) as java.util.jar.Attributes.Name;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.jar.Attributes.Name.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Attributes$Name"));
				global::java.util.jar.Attributes.Name._equals27696 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::java.util.jar.Attributes.Name._toString27697 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "toString", "()Ljava/lang/String;");
				global::java.util.jar.Attributes.Name._hashCode27698 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "hashCode", "()I");
				global::java.util.jar.Attributes.Name._Name27699 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::java.util.jar.Attributes.Name._MANIFEST_VERSION27700 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "MANIFEST_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SIGNATURE_VERSION27701 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SIGNATURE_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._CONTENT_TYPE27702 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "CONTENT_TYPE", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._CLASS_PATH27703 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "CLASS_PATH", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._MAIN_CLASS27704 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "MAIN_CLASS", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SEALED27705 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SEALED", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._EXTENSION_LIST27706 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "EXTENSION_LIST", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._EXTENSION_NAME27707 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "EXTENSION_NAME", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._EXTENSION_INSTALLATION27708 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "EXTENSION_INSTALLATION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_TITLE27709 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_TITLE", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_VERSION27710 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_VENDOR27711 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_VENDOR", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_VENDOR_ID27712 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_VENDOR_ID", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_URL27713 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_URL", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SPECIFICATION_TITLE27714 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SPECIFICATION_TITLE", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SPECIFICATION_VERSION27715 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SPECIFICATION_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SPECIFICATION_VENDOR27716 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SPECIFICATION_VENDOR", "Ljava/util/jar/Attributes$Name;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _get27717;
		public virtual global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._get27717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._get27717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put27718;
		public virtual global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._put27718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._put27718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals27719;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._equals27719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._equals27719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values27720;
		public virtual global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._values27720)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._values27720)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27721;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.Attributes._hashCode27721);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._hashCode27721);
		}
		internal static global::MonoJavaBridge.MethodId _clone27722;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._clone27722)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._clone27722)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear27723;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Attributes._clear27723);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._clear27723);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27724;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._isEmpty27724);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._isEmpty27724);
		}
		internal static global::MonoJavaBridge.MethodId _getValue27725;
		public virtual global::java.lang.String getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._getValue27725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._getValue27725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue27726;
		public virtual global::java.lang.String getValue(java.util.jar.Attributes.Name arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._getValue27726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._getValue27726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size27727;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.Attributes._size27727);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._size27727);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet27728;
		public virtual global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._entrySet27728)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._entrySet27728)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll27729;
		public virtual void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Attributes._putAll27729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._putAll27729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove27730;
		public virtual global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._remove27730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._remove27730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet27731;
		public virtual global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._keySet27731)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._keySet27731)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue27732;
		public virtual bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._containsValue27732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._containsValue27732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey27733;
		public virtual bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._containsKey27733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._containsKey27733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putValue27734;
		public virtual global::java.lang.String putValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._putValue27734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._putValue27734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Attributes27735;
		public Attributes(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._Attributes27735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Attributes27736;
		public Attributes(java.util.jar.Attributes arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._Attributes27736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Attributes27737;
		public Attributes()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._Attributes27737);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.Attributes.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Attributes"));
			global::java.util.jar.Attributes._get27717 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.jar.Attributes._put27718 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.jar.Attributes._equals27719 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.jar.Attributes._values27720 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.jar.Attributes._hashCode27721 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "hashCode", "()I");
			global::java.util.jar.Attributes._clone27722 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.jar.Attributes._clear27723 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "clear", "()V");
			global::java.util.jar.Attributes._isEmpty27724 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "isEmpty", "()Z");
			global::java.util.jar.Attributes._getValue27725 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.jar.Attributes._getValue27726 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "getValue", "(Ljava/util/jar/Attributes$Name;)Ljava/lang/String;");
			global::java.util.jar.Attributes._size27727 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "size", "()I");
			global::java.util.jar.Attributes._entrySet27728 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.jar.Attributes._putAll27729 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.jar.Attributes._remove27730 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.jar.Attributes._keySet27731 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.jar.Attributes._containsValue27732 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.jar.Attributes._containsKey27733 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.jar.Attributes._putValue27734 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "putValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.jar.Attributes._Attributes27735 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "(I)V");
			global::java.util.jar.Attributes._Attributes27736 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "(Ljava/util/jar/Attributes;)V");
			global::java.util.jar.Attributes._Attributes27737 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "()V");
		}
	}
}
