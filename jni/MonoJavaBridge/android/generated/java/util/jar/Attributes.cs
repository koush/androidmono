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
			internal static global::MonoJavaBridge.MethodId _equals27814;
			public override bool equals(java.lang.Object arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.Name._equals27814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._equals27814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString27815;
			public override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.Name._toString27815)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._toString27815)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode27816;
			public override int hashCode()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.Attributes.Name._hashCode27816);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._hashCode27816);
			}
			internal static global::MonoJavaBridge.MethodId _Name27817;
			public Name(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.Name.staticClass, global::java.util.jar.Attributes.Name._Name27817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _MANIFEST_VERSION27818;
			public static global::java.util.jar.Attributes.Name MANIFEST_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _MANIFEST_VERSION27818)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SIGNATURE_VERSION27819;
			public static global::java.util.jar.Attributes.Name SIGNATURE_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SIGNATURE_VERSION27819)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_TYPE27820;
			public static global::java.util.jar.Attributes.Name CONTENT_TYPE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _CONTENT_TYPE27820)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_PATH27821;
			public static global::java.util.jar.Attributes.Name CLASS_PATH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _CLASS_PATH27821)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MAIN_CLASS27822;
			public static global::java.util.jar.Attributes.Name MAIN_CLASS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _MAIN_CLASS27822)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SEALED27823;
			public static global::java.util.jar.Attributes.Name SEALED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SEALED27823)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_LIST27824;
			public static global::java.util.jar.Attributes.Name EXTENSION_LIST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _EXTENSION_LIST27824)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_NAME27825;
			public static global::java.util.jar.Attributes.Name EXTENSION_NAME
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _EXTENSION_NAME27825)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXTENSION_INSTALLATION27826;
			public static global::java.util.jar.Attributes.Name EXTENSION_INSTALLATION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _EXTENSION_INSTALLATION27826)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_TITLE27827;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_TITLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_TITLE27827)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VERSION27828;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_VERSION27828)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VENDOR27829;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VENDOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_VENDOR27829)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_VENDOR_ID27830;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_VENDOR_ID
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_VENDOR_ID27830)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IMPLEMENTATION_URL27831;
			public static global::java.util.jar.Attributes.Name IMPLEMENTATION_URL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _IMPLEMENTATION_URL27831)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_TITLE27832;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_TITLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SPECIFICATION_TITLE27832)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_VERSION27833;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_VERSION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SPECIFICATION_VERSION27833)) as java.util.jar.Attributes.Name;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIFICATION_VENDOR27834;
			public static global::java.util.jar.Attributes.Name SPECIFICATION_VENDOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.jar.Attributes.Name.staticClass, _SPECIFICATION_VENDOR27834)) as java.util.jar.Attributes.Name;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.jar.Attributes.Name.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Attributes$Name"));
				global::java.util.jar.Attributes.Name._equals27814 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::java.util.jar.Attributes.Name._toString27815 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "toString", "()Ljava/lang/String;");
				global::java.util.jar.Attributes.Name._hashCode27816 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "hashCode", "()I");
				global::java.util.jar.Attributes.Name._Name27817 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::java.util.jar.Attributes.Name._MANIFEST_VERSION27818 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "MANIFEST_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SIGNATURE_VERSION27819 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SIGNATURE_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._CONTENT_TYPE27820 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "CONTENT_TYPE", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._CLASS_PATH27821 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "CLASS_PATH", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._MAIN_CLASS27822 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "MAIN_CLASS", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SEALED27823 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SEALED", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._EXTENSION_LIST27824 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "EXTENSION_LIST", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._EXTENSION_NAME27825 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "EXTENSION_NAME", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._EXTENSION_INSTALLATION27826 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "EXTENSION_INSTALLATION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_TITLE27827 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_TITLE", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_VERSION27828 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_VENDOR27829 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_VENDOR", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_VENDOR_ID27830 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_VENDOR_ID", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._IMPLEMENTATION_URL27831 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "IMPLEMENTATION_URL", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SPECIFICATION_TITLE27832 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SPECIFICATION_TITLE", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SPECIFICATION_VERSION27833 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SPECIFICATION_VERSION", "Ljava/util/jar/Attributes$Name;");
				global::java.util.jar.Attributes.Name._SPECIFICATION_VENDOR27834 = @__env.GetStaticFieldIDNoThrow(global::java.util.jar.Attributes.Name.staticClass, "SPECIFICATION_VENDOR", "Ljava/util/jar/Attributes$Name;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _get27835;
		public virtual global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._get27835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._get27835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put27836;
		public virtual global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._put27836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._put27836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals27837;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._equals27837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._equals27837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values27838;
		public virtual global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._values27838)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._values27838)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27839;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.Attributes._hashCode27839);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._hashCode27839);
		}
		internal static global::MonoJavaBridge.MethodId _clone27840;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._clone27840)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._clone27840)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear27841;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Attributes._clear27841);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._clear27841);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27842;
		public virtual bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._isEmpty27842);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._isEmpty27842);
		}
		internal static global::MonoJavaBridge.MethodId _getValue27843;
		public virtual global::java.lang.String getValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._getValue27843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._getValue27843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue27844;
		public virtual global::java.lang.String getValue(java.util.jar.Attributes.Name arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._getValue27844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._getValue27844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size27845;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.Attributes._size27845);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._size27845);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet27846;
		public virtual global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._entrySet27846)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._entrySet27846)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll27847;
		public virtual void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Attributes._putAll27847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._putAll27847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove27848;
		public virtual global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._remove27848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._remove27848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet27849;
		public virtual global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._keySet27849)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._keySet27849)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue27850;
		public virtual bool containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._containsValue27850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._containsValue27850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey27851;
		public virtual bool containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes._containsKey27851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._containsKey27851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putValue27852;
		public virtual global::java.lang.String putValue(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Attributes._putValue27852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._putValue27852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Attributes27853;
		public Attributes(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._Attributes27853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Attributes27854;
		public Attributes(java.util.jar.Attributes arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._Attributes27854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Attributes27855;
		public Attributes() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Attributes.staticClass, global::java.util.jar.Attributes._Attributes27855);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.Attributes.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Attributes"));
			global::java.util.jar.Attributes._get27835 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.jar.Attributes._put27836 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.jar.Attributes._equals27837 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.jar.Attributes._values27838 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.jar.Attributes._hashCode27839 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "hashCode", "()I");
			global::java.util.jar.Attributes._clone27840 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.jar.Attributes._clear27841 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "clear", "()V");
			global::java.util.jar.Attributes._isEmpty27842 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "isEmpty", "()Z");
			global::java.util.jar.Attributes._getValue27843 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.jar.Attributes._getValue27844 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "getValue", "(Ljava/util/jar/Attributes$Name;)Ljava/lang/String;");
			global::java.util.jar.Attributes._size27845 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "size", "()I");
			global::java.util.jar.Attributes._entrySet27846 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.jar.Attributes._putAll27847 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.jar.Attributes._remove27848 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.jar.Attributes._keySet27849 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.jar.Attributes._containsValue27850 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.jar.Attributes._containsKey27851 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.jar.Attributes._putValue27852 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "putValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.jar.Attributes._Attributes27853 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "(I)V");
			global::java.util.jar.Attributes._Attributes27854 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "(Ljava/util/jar/Attributes;)V");
			global::java.util.jar.Attributes._Attributes27855 = @__env.GetMethodIDNoThrow(global::java.util.jar.Attributes.staticClass, "<init>", "()V");
		}
	}
}
