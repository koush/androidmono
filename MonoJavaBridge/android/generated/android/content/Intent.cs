namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Intent : java.lang.Object, android.os.Parcelable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Intent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class FilterComparison : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal FilterComparison(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _equals3100;
			public sealed override bool equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.FilterComparison.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.Intent.FilterComparison._equals3100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _hashCode3101;
			public sealed override int hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.FilterComparison.staticClass, "hashCode", "()I", ref global::android.content.Intent.FilterComparison._hashCode3101);
			}
			public new global::android.content.Intent Intent
			{
				get
				{
					return getIntent();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getIntent3102;
			public global::android.content.Intent getIntent()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.FilterComparison.staticClass, "getIntent", "()Landroid/content/Intent;", ref global::android.content.Intent.FilterComparison._getIntent3102) as android.content.Intent;
			}
			internal static global::MonoJavaBridge.MethodId _FilterComparison3103;
			public FilterComparison(android.content.Intent arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.Intent.FilterComparison._FilterComparison3103.native == global::System.IntPtr.Zero)
					global::android.content.Intent.FilterComparison._FilterComparison3103 = @__env.GetMethodIDNoThrow(global::android.content.Intent.FilterComparison.staticClass, "<init>", "(Landroid/content/Intent;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.FilterComparison.staticClass, global::android.content.Intent.FilterComparison._FilterComparison3103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static FilterComparison()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.Intent.FilterComparison.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Intent$FilterComparison"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ShortcutIconResource : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ShortcutIconResource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString3104;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.ShortcutIconResource.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.Intent.ShortcutIconResource._toString3104) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel3105;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.ShortcutIconResource.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.Intent.ShortcutIconResource._writeToParcel3105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents3106;
			public virtual int describeContents()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.ShortcutIconResource.staticClass, "describeContents", "()I", ref global::android.content.Intent.ShortcutIconResource._describeContents3106);
			}
			internal static global::MonoJavaBridge.MethodId _fromContext3107;
			public static global::android.content.Intent.ShortcutIconResource fromContext(android.content.Context arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.Intent.ShortcutIconResource._fromContext3107.native == global::System.IntPtr.Zero)
					global::android.content.Intent.ShortcutIconResource._fromContext3107 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "fromContext", "(Landroid/content/Context;I)Landroid/content/Intent$ShortcutIconResource;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._fromContext3107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent.ShortcutIconResource;
			}
			internal static global::MonoJavaBridge.MethodId _ShortcutIconResource3108;
			public ShortcutIconResource() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.Intent.ShortcutIconResource._ShortcutIconResource3108.native == global::System.IntPtr.Zero)
					global::android.content.Intent.ShortcutIconResource._ShortcutIconResource3108 = @__env.GetMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._ShortcutIconResource3108);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _packageName3109;
			public global::java.lang.String packageName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName3109)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _resourceName3110;
			public global::java.lang.String resourceName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _resourceName3110)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR3111;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.Intent.ShortcutIconResource.staticClass, _CREATOR3111)) as android.os.Parcelable_Creator;
				}
			}
			static ShortcutIconResource()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.Intent.ShortcutIconResource.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Intent$ShortcutIconResource"));
				global::android.content.Intent.ShortcutIconResource._packageName3109 = @__env.GetFieldIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "packageName", "Ljava/lang/String;");
				global::android.content.Intent.ShortcutIconResource._resourceName3110 = @__env.GetFieldIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "resourceName", "Ljava/lang/String;");
				global::android.content.Intent.ShortcutIconResource._CREATOR3111 = @__env.GetStaticFieldIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString3112;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.Intent._toString3112) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone3113;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "clone", "()Ljava/lang/Object;", ref global::android.content.Intent._clone3113) as java.lang.Object;
		}
		public new global::java.lang.String Package
		{
			get
			{
				return getPackage();
			}
			set
			{
				setPackage(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackage3114;
		public virtual global::java.lang.String getPackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getPackage", "()Ljava/lang/String;", ref global::android.content.Intent._getPackage3114) as java.lang.String;
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
			set
			{
				setType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType3115;
		public virtual global::java.lang.String getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getType", "()Ljava/lang/String;", ref global::android.content.Intent._getType3115) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toURI3116;
		public virtual global::java.lang.String toURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "toURI", "()Ljava/lang/String;", ref global::android.content.Intent._toURI3116) as java.lang.String;
		}
		public new global::java.lang.String Scheme
		{
			get
			{
				return getScheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScheme3117;
		public virtual global::java.lang.String getScheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getScheme", "()Ljava/lang/String;", ref global::android.content.Intent._getScheme3117) as java.lang.String;
		}
		public new global::android.net.Uri Data
		{
			get
			{
				return getData();
			}
			set
			{
				setData(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getData3118;
		public virtual global::android.net.Uri getData()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "getData", "()Landroid/net/Uri;", ref global::android.content.Intent._getData3118) as android.net.Uri;
		}
		public new global::android.content.ComponentName Component
		{
			get
			{
				return getComponent();
			}
			set
			{
				setComponent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponent3119;
		public virtual global::android.content.ComponentName getComponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.content.Intent.staticClass, "getComponent", "()Landroid/content/ComponentName;", ref global::android.content.Intent._getComponent3119) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _setClassName3120;
		public virtual global::android.content.Intent setClassName(android.content.Context arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setClassName", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._setClassName3120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setClassName3121;
		public virtual global::android.content.Intent setClassName(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setClassName", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._setClassName3121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3122;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.Intent._writeToParcel3122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3123;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.staticClass, "describeContents", "()I", ref global::android.content.Intent._describeContents3123);
		}
		internal static global::MonoJavaBridge.MethodId _createChooser3124;
		public static global::android.content.Intent createChooser(android.content.Intent arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._createChooser3124.native == global::System.IntPtr.Zero)
				global::android.content.Intent._createChooser3124 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "createChooser", "(Landroid/content/Intent;Ljava/lang/CharSequence;)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._createChooser3124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		public static android.content.Intent createChooser(android.content.Intent arg0, string arg1)
		{
			return createChooser(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _cloneFilter3125;
		public virtual global::android.content.Intent cloneFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "cloneFilter", "()Landroid/content/Intent;", ref global::android.content.Intent._cloneFilter3125) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getIntent3126;
		public static global::android.content.Intent getIntent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._getIntent3126.native == global::System.IntPtr.Zero)
				global::android.content.Intent._getIntent3126 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntent", "(Ljava/lang/String;)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._getIntent3126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _parseUri3127;
		public static global::android.content.Intent parseUri(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._parseUri3127.native == global::System.IntPtr.Zero)
				global::android.content.Intent._parseUri3127 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "parseUri", "(Ljava/lang/String;I)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._parseUri3127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getIntentOld3128;
		public static global::android.content.Intent getIntentOld(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._getIntentOld3128.native == global::System.IntPtr.Zero)
				global::android.content.Intent._getIntentOld3128 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntentOld", "(Ljava/lang/String;)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._getIntentOld3128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		public new global::java.lang.String Action
		{
			get
			{
				return getAction();
			}
			set
			{
				setAction(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAction3129;
		public virtual global::java.lang.String getAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getAction", "()Ljava/lang/String;", ref global::android.content.Intent._getAction3129) as java.lang.String;
		}
		public new global::java.lang.String DataString
		{
			get
			{
				return getDataString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDataString3130;
		public virtual global::java.lang.String getDataString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getDataString", "()Ljava/lang/String;", ref global::android.content.Intent._getDataString3130) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _resolveType3131;
		public virtual global::java.lang.String resolveType(android.content.Context arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "resolveType", "(Landroid/content/Context;)Ljava/lang/String;", ref global::android.content.Intent._resolveType3131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _resolveType3132;
		public virtual global::java.lang.String resolveType(android.content.ContentResolver arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "resolveType", "(Landroid/content/ContentResolver;)Ljava/lang/String;", ref global::android.content.Intent._resolveType3132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _resolveTypeIfNeeded3133;
		public virtual global::java.lang.String resolveTypeIfNeeded(android.content.ContentResolver arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "resolveTypeIfNeeded", "(Landroid/content/ContentResolver;)Ljava/lang/String;", ref global::android.content.Intent._resolveTypeIfNeeded3133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasCategory3134;
		public virtual bool hasCategory(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.staticClass, "hasCategory", "(Ljava/lang/String;)Z", ref global::android.content.Intent._hasCategory3134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Set Categories
		{
			get
			{
				return getCategories();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCategories3135;
		public virtual global::java.util.Set getCategories()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.content.Intent.staticClass, "getCategories", "()Ljava/util/Set;", ref global::android.content.Intent._getCategories3135) as java.util.Set;
		}
		public new global::java.lang.ClassLoader ExtrasClassLoader
		{
			set
			{
				setExtrasClassLoader(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setExtrasClassLoader3136;
		public virtual void setExtrasClassLoader(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "setExtrasClassLoader", "(Ljava/lang/ClassLoader;)V", ref global::android.content.Intent._setExtrasClassLoader3136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasExtra3137;
		public virtual bool hasExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.staticClass, "hasExtra", "(Ljava/lang/String;)Z", ref global::android.content.Intent._hasExtra3137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasFileDescriptors3138;
		public virtual bool hasFileDescriptors()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.staticClass, "hasFileDescriptors", "()Z", ref global::android.content.Intent._hasFileDescriptors3138);
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanExtra3139;
		public virtual bool getBooleanExtra(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.staticClass, "getBooleanExtra", "(Ljava/lang/String;Z)Z", ref global::android.content.Intent._getBooleanExtra3139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByteExtra3140;
		public virtual byte getByteExtra(java.lang.String arg0, byte arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::android.content.Intent.staticClass, "getByteExtra", "(Ljava/lang/String;B)B", ref global::android.content.Intent._getByteExtra3140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShortExtra3141;
		public virtual short getShortExtra(java.lang.String arg0, short arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.content.Intent.staticClass, "getShortExtra", "(Ljava/lang/String;S)S", ref global::android.content.Intent._getShortExtra3141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCharExtra3142;
		public virtual char getCharExtra(java.lang.String arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.content.Intent.staticClass, "getCharExtra", "(Ljava/lang/String;C)C", ref global::android.content.Intent._getCharExtra3142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getIntExtra3143;
		public virtual int getIntExtra(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.staticClass, "getIntExtra", "(Ljava/lang/String;I)I", ref global::android.content.Intent._getIntExtra3143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLongExtra3144;
		public virtual long getLongExtra(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.Intent.staticClass, "getLongExtra", "(Ljava/lang/String;J)J", ref global::android.content.Intent._getLongExtra3144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloatExtra3145;
		public virtual float getFloatExtra(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.Intent.staticClass, "getFloatExtra", "(Ljava/lang/String;F)F", ref global::android.content.Intent._getFloatExtra3145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleExtra3146;
		public virtual double getDoubleExtra(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.content.Intent.staticClass, "getDoubleExtra", "(Ljava/lang/String;D)D", ref global::android.content.Intent._getDoubleExtra3146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getStringExtra3147;
		public virtual global::java.lang.String getStringExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getStringExtra", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.content.Intent._getStringExtra3147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceExtra3148;
		public virtual global::java.lang.CharSequence getCharSequenceExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.Intent.staticClass, "getCharSequenceExtra", "(Ljava/lang/String;)Ljava/lang/CharSequence;", ref global::android.content.Intent._getCharSequenceExtra3148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableExtra3149;
		public virtual global::android.os.Parcelable getParcelableExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.content.Intent.staticClass, "getParcelableExtra", "(Ljava/lang/String;)Landroid/os/Parcelable;", ref global::android.content.Intent._getParcelableExtra3149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArrayExtra3150;
		public virtual global::android.os.Parcelable[] getParcelableArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.os.Parcelable>(this, global::android.content.Intent.staticClass, "getParcelableArrayExtra", "(Ljava/lang/String;)[Landroid/os/Parcelable;", ref global::android.content.Intent._getParcelableArrayExtra3150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Parcelable[];
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArrayListExtra3151;
		public virtual global::java.util.ArrayList getParcelableArrayListExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "getParcelableArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.content.Intent._getParcelableArrayListExtra3151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getSerializableExtra3152;
		public virtual global::java.io.Serializable getSerializableExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.io.Serializable>(this, global::android.content.Intent.staticClass, "getSerializableExtra", "(Ljava/lang/String;)Ljava/io/Serializable;", ref global::android.content.Intent._getSerializableExtra3152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Serializable;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerArrayListExtra3153;
		public virtual global::java.util.ArrayList getIntegerArrayListExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "getIntegerArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.content.Intent._getIntegerArrayListExtra3153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getStringArrayListExtra3154;
		public virtual global::java.util.ArrayList getStringArrayListExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "getStringArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.content.Intent._getStringArrayListExtra3154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArrayListExtra3155;
		public virtual global::java.util.ArrayList getCharSequenceArrayListExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "getCharSequenceArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.content.Intent._getCharSequenceArrayListExtra3155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanArrayExtra3156;
		public virtual bool[] getBooleanArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::android.content.Intent.staticClass, "getBooleanArrayExtra", "(Ljava/lang/String;)[Z", ref global::android.content.Intent._getBooleanArrayExtra3156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getByteArrayExtra3157;
		public virtual byte[] getByteArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.content.Intent.staticClass, "getByteArrayExtra", "(Ljava/lang/String;)[B", ref global::android.content.Intent._getByteArrayExtra3157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getShortArrayExtra3158;
		public virtual short[] getShortArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<short>(this, global::android.content.Intent.staticClass, "getShortArrayExtra", "(Ljava/lang/String;)[S", ref global::android.content.Intent._getShortArrayExtra3158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharArrayExtra3159;
		public virtual char[] getCharArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.content.Intent.staticClass, "getCharArrayExtra", "(Ljava/lang/String;)[C", ref global::android.content.Intent._getCharArrayExtra3159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getIntArrayExtra3160;
		public virtual int[] getIntArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.content.Intent.staticClass, "getIntArrayExtra", "(Ljava/lang/String;)[I", ref global::android.content.Intent._getIntArrayExtra3160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getLongArrayExtra3161;
		public virtual long[] getLongArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<long>(this, global::android.content.Intent.staticClass, "getLongArrayExtra", "(Ljava/lang/String;)[J", ref global::android.content.Intent._getLongArrayExtra3161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _getFloatArrayExtra3162;
		public virtual float[] getFloatArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<float>(this, global::android.content.Intent.staticClass, "getFloatArrayExtra", "(Ljava/lang/String;)[F", ref global::android.content.Intent._getFloatArrayExtra3162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleArrayExtra3163;
		public virtual double[] getDoubleArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<double>(this, global::android.content.Intent.staticClass, "getDoubleArrayExtra", "(Ljava/lang/String;)[D", ref global::android.content.Intent._getDoubleArrayExtra3163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _getStringArrayExtra3164;
		public virtual global::java.lang.String[] getStringArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getStringArrayExtra", "(Ljava/lang/String;)[Ljava/lang/String;", ref global::android.content.Intent._getStringArrayExtra3164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArrayExtra3165;
		public virtual global::java.lang.CharSequence[] getCharSequenceArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.CharSequence>(this, global::android.content.Intent.staticClass, "getCharSequenceArrayExtra", "(Ljava/lang/String;)[Ljava/lang/CharSequence;", ref global::android.content.Intent._getCharSequenceArrayExtra3165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _getBundleExtra3166;
		public virtual global::android.os.Bundle getBundleExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.content.Intent.staticClass, "getBundleExtra", "(Ljava/lang/String;)Landroid/os/Bundle;", ref global::android.content.Intent._getBundleExtra3166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtras3167;
		public virtual global::android.os.Bundle getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.content.Intent.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.content.Intent._getExtras3167) as android.os.Bundle;
		}
		public new int Flags
		{
			get
			{
				return getFlags();
			}
			set
			{
				setFlags(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFlags3168;
		public virtual int getFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.staticClass, "getFlags", "()I", ref global::android.content.Intent._getFlags3168);
		}
		public new global::android.graphics.Rect SourceBounds
		{
			get
			{
				return getSourceBounds();
			}
			set
			{
				setSourceBounds(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSourceBounds3169;
		public virtual global::android.graphics.Rect getSourceBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Rect>(this, global::android.content.Intent.staticClass, "getSourceBounds", "()Landroid/graphics/Rect;", ref global::android.content.Intent._getSourceBounds3169) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _resolveActivity3170;
		public virtual global::android.content.ComponentName resolveActivity(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.content.Intent.staticClass, "resolveActivity", "(Landroid/content/pm/PackageManager;)Landroid/content/ComponentName;", ref global::android.content.Intent._resolveActivity3170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _resolveActivityInfo3171;
		public virtual global::android.content.pm.ActivityInfo resolveActivityInfo(android.content.pm.PackageManager arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "resolveActivityInfo", "(Landroid/content/pm/PackageManager;I)Landroid/content/pm/ActivityInfo;", ref global::android.content.Intent._resolveActivityInfo3171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _setAction3172;
		public virtual global::android.content.Intent setAction(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setAction", "(Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._setAction3172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setData3173;
		public virtual global::android.content.Intent setData(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setData", "(Landroid/net/Uri;)Landroid/content/Intent;", ref global::android.content.Intent._setData3173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setType3174;
		public virtual global::android.content.Intent setType(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setType", "(Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._setType3174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setDataAndType3175;
		public virtual global::android.content.Intent setDataAndType(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setDataAndType", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._setDataAndType3175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _addCategory3176;
		public virtual global::android.content.Intent addCategory(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "addCategory", "(Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._addCategory3176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _removeCategory3177;
		public virtual void removeCategory(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "removeCategory", "(Ljava/lang/String;)V", ref global::android.content.Intent._removeCategory3177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3178;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, bool[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Z)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3179;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Z)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3180;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, byte arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;B)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3181;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;C)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3182;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, short arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;S)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3183;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;I)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3184;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;J)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3185;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;F)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3186;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;D)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3187;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3188;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/lang/CharSequence;)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		public android.content.Intent putExtra(java.lang.String arg0, string arg1)
		{
			return putExtra(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3189;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Parcelable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Landroid/os/Parcelable;)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3190;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Parcelable[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Landroid/os/Parcelable;)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3191;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.io.Serializable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3192;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, byte[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[B)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3193;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, short[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[S)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3194;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, char[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[C)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3195;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[I)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3196;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, long[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[J)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3197;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, float[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[F)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3198;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, double[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[D)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3199;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3200;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.CharSequence[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Ljava/lang/CharSequence;)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3201;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Bundle arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;", ref global::android.content.Intent._putExtra3201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putParcelableArrayListExtra3202;
		public virtual global::android.content.Intent putParcelableArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putParcelableArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", ref global::android.content.Intent._putParcelableArrayListExtra3202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putIntegerArrayListExtra3203;
		public virtual global::android.content.Intent putIntegerArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putIntegerArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", ref global::android.content.Intent._putIntegerArrayListExtra3203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putStringArrayListExtra3204;
		public virtual global::android.content.Intent putStringArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putStringArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", ref global::android.content.Intent._putStringArrayListExtra3204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequenceArrayListExtra3205;
		public virtual global::android.content.Intent putCharSequenceArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putCharSequenceArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", ref global::android.content.Intent._putCharSequenceArrayListExtra3205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtras3206;
		public virtual global::android.content.Intent putExtras(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;", ref global::android.content.Intent._putExtras3206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtras3207;
		public virtual global::android.content.Intent putExtras(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtras", "(Landroid/content/Intent;)Landroid/content/Intent;", ref global::android.content.Intent._putExtras3207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _replaceExtras3208;
		public virtual global::android.content.Intent replaceExtras(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "replaceExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;", ref global::android.content.Intent._replaceExtras3208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _replaceExtras3209;
		public virtual global::android.content.Intent replaceExtras(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "replaceExtras", "(Landroid/content/Intent;)Landroid/content/Intent;", ref global::android.content.Intent._replaceExtras3209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _removeExtra3210;
		public virtual void removeExtra(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "removeExtra", "(Ljava/lang/String;)V", ref global::android.content.Intent._removeExtra3210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFlags3211;
		public virtual global::android.content.Intent setFlags(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setFlags", "(I)Landroid/content/Intent;", ref global::android.content.Intent._setFlags3211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _addFlags3212;
		public virtual global::android.content.Intent addFlags(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "addFlags", "(I)Landroid/content/Intent;", ref global::android.content.Intent._addFlags3212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setPackage3213;
		public virtual global::android.content.Intent setPackage(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setPackage", "(Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._setPackage3213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setComponent3214;
		public virtual global::android.content.Intent setComponent(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setComponent", "(Landroid/content/ComponentName;)Landroid/content/Intent;", ref global::android.content.Intent._setComponent3214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setClass3215;
		public virtual global::android.content.Intent setClass(android.content.Context arg0, java.lang.Class arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setClass", "(Landroid/content/Context;Ljava/lang/Class;)Landroid/content/Intent;", ref global::android.content.Intent._setClass3215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setSourceBounds3216;
		public virtual void setSourceBounds(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "setSourceBounds", "(Landroid/graphics/Rect;)V", ref global::android.content.Intent._setSourceBounds3216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fillIn3217;
		public virtual int fillIn(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.staticClass, "fillIn", "(Landroid/content/Intent;I)I", ref global::android.content.Intent._fillIn3217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _filterEquals3218;
		public virtual bool filterEquals(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.staticClass, "filterEquals", "(Landroid/content/Intent;)Z", ref global::android.content.Intent._filterEquals3218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _filterHashCode3219;
		public virtual int filterHashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.staticClass, "filterHashCode", "()I", ref global::android.content.Intent._filterHashCode3219);
		}
		internal static global::MonoJavaBridge.MethodId _toUri3220;
		public virtual global::java.lang.String toUri(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "toUri", "(I)Ljava/lang/String;", ref global::android.content.Intent._toUri3220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel3221;
		public virtual void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.content.Intent._readFromParcel3221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseIntent3222;
		public static global::android.content.Intent parseIntent(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._parseIntent3222.native == global::System.IntPtr.Zero)
				global::android.content.Intent._parseIntent3222 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "parseIntent", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._parseIntent3222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _Intent3223;
		public Intent() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._Intent3223.native == global::System.IntPtr.Zero)
				global::android.content.Intent._Intent3223 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3223);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent3224;
		public Intent(android.content.Intent arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._Intent3224.native == global::System.IntPtr.Zero)
				global::android.content.Intent._Intent3224 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Landroid/content/Intent;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent3225;
		public Intent(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._Intent3225.native == global::System.IntPtr.Zero)
				global::android.content.Intent._Intent3225 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent3226;
		public Intent(java.lang.String arg0, android.net.Uri arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._Intent3226.native == global::System.IntPtr.Zero)
				global::android.content.Intent._Intent3226 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/Uri;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent3227;
		public Intent(android.content.Context arg0, java.lang.Class arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._Intent3227.native == global::System.IntPtr.Zero)
				global::android.content.Intent._Intent3227 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent3228;
		public Intent(java.lang.String arg0, android.net.Uri arg1, android.content.Context arg2, java.lang.Class arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._Intent3228.native == global::System.IntPtr.Zero)
				global::android.content.Intent._Intent3228 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/Uri;Landroid/content/Context;Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		public static global::java.lang.String ACTION_MAIN
		{
			get
			{
				return "android.intent.action.MAIN";
			}
		}
		public static global::java.lang.String ACTION_VIEW
		{
			get
			{
				return "android.intent.action.VIEW";
			}
		}
		public static global::java.lang.String ACTION_DEFAULT
		{
			get
			{
				return "android.intent.action.VIEW";
			}
		}
		public static global::java.lang.String ACTION_ATTACH_DATA
		{
			get
			{
				return "android.intent.action.ATTACH_DATA";
			}
		}
		public static global::java.lang.String ACTION_EDIT
		{
			get
			{
				return "android.intent.action.EDIT";
			}
		}
		public static global::java.lang.String ACTION_INSERT_OR_EDIT
		{
			get
			{
				return "android.intent.action.INSERT_OR_EDIT";
			}
		}
		public static global::java.lang.String ACTION_PICK
		{
			get
			{
				return "android.intent.action.PICK";
			}
		}
		public static global::java.lang.String ACTION_CREATE_SHORTCUT
		{
			get
			{
				return "android.intent.action.CREATE_SHORTCUT";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_INTENT
		{
			get
			{
				return "android.intent.extra.shortcut.INTENT";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_NAME
		{
			get
			{
				return "android.intent.extra.shortcut.NAME";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_ICON
		{
			get
			{
				return "android.intent.extra.shortcut.ICON";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_ICON_RESOURCE
		{
			get
			{
				return "android.intent.extra.shortcut.ICON_RESOURCE";
			}
		}
		public static global::java.lang.String ACTION_CHOOSER
		{
			get
			{
				return "android.intent.action.CHOOSER";
			}
		}
		public static global::java.lang.String ACTION_GET_CONTENT
		{
			get
			{
				return "android.intent.action.GET_CONTENT";
			}
		}
		public static global::java.lang.String ACTION_DIAL
		{
			get
			{
				return "android.intent.action.DIAL";
			}
		}
		public static global::java.lang.String ACTION_CALL
		{
			get
			{
				return "android.intent.action.CALL";
			}
		}
		public static global::java.lang.String ACTION_SENDTO
		{
			get
			{
				return "android.intent.action.SENDTO";
			}
		}
		public static global::java.lang.String ACTION_SEND
		{
			get
			{
				return "android.intent.action.SEND";
			}
		}
		public static global::java.lang.String ACTION_SEND_MULTIPLE
		{
			get
			{
				return "android.intent.action.SEND_MULTIPLE";
			}
		}
		public static global::java.lang.String ACTION_ANSWER
		{
			get
			{
				return "android.intent.action.ANSWER";
			}
		}
		public static global::java.lang.String ACTION_INSERT
		{
			get
			{
				return "android.intent.action.INSERT";
			}
		}
		public static global::java.lang.String ACTION_DELETE
		{
			get
			{
				return "android.intent.action.DELETE";
			}
		}
		public static global::java.lang.String ACTION_RUN
		{
			get
			{
				return "android.intent.action.RUN";
			}
		}
		public static global::java.lang.String ACTION_SYNC
		{
			get
			{
				return "android.intent.action.SYNC";
			}
		}
		public static global::java.lang.String ACTION_PICK_ACTIVITY
		{
			get
			{
				return "android.intent.action.PICK_ACTIVITY";
			}
		}
		public static global::java.lang.String ACTION_SEARCH
		{
			get
			{
				return "android.intent.action.SEARCH";
			}
		}
		public static global::java.lang.String ACTION_SYSTEM_TUTORIAL
		{
			get
			{
				return "android.intent.action.SYSTEM_TUTORIAL";
			}
		}
		public static global::java.lang.String ACTION_WEB_SEARCH
		{
			get
			{
				return "android.intent.action.WEB_SEARCH";
			}
		}
		public static global::java.lang.String ACTION_ALL_APPS
		{
			get
			{
				return "android.intent.action.ALL_APPS";
			}
		}
		public static global::java.lang.String ACTION_SET_WALLPAPER
		{
			get
			{
				return "android.intent.action.SET_WALLPAPER";
			}
		}
		public static global::java.lang.String ACTION_BUG_REPORT
		{
			get
			{
				return "android.intent.action.BUG_REPORT";
			}
		}
		public static global::java.lang.String ACTION_FACTORY_TEST
		{
			get
			{
				return "android.intent.action.FACTORY_TEST";
			}
		}
		public static global::java.lang.String ACTION_CALL_BUTTON
		{
			get
			{
				return "android.intent.action.CALL_BUTTON";
			}
		}
		public static global::java.lang.String ACTION_VOICE_COMMAND
		{
			get
			{
				return "android.intent.action.VOICE_COMMAND";
			}
		}
		public static global::java.lang.String ACTION_SEARCH_LONG_PRESS
		{
			get
			{
				return "android.intent.action.SEARCH_LONG_PRESS";
			}
		}
		public static global::java.lang.String ACTION_POWER_USAGE_SUMMARY
		{
			get
			{
				return "android.intent.action.POWER_USAGE_SUMMARY";
			}
		}
		public static global::java.lang.String ACTION_SCREEN_OFF
		{
			get
			{
				return "android.intent.action.SCREEN_OFF";
			}
		}
		public static global::java.lang.String ACTION_SCREEN_ON
		{
			get
			{
				return "android.intent.action.SCREEN_ON";
			}
		}
		public static global::java.lang.String ACTION_USER_PRESENT
		{
			get
			{
				return "android.intent.action.USER_PRESENT";
			}
		}
		public static global::java.lang.String ACTION_TIME_TICK
		{
			get
			{
				return "android.intent.action.TIME_TICK";
			}
		}
		public static global::java.lang.String ACTION_TIME_CHANGED
		{
			get
			{
				return "android.intent.action.TIME_SET";
			}
		}
		public static global::java.lang.String ACTION_DATE_CHANGED
		{
			get
			{
				return "android.intent.action.DATE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_TIMEZONE_CHANGED
		{
			get
			{
				return "android.intent.action.TIMEZONE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_BOOT_COMPLETED
		{
			get
			{
				return "android.intent.action.BOOT_COMPLETED";
			}
		}
		public static global::java.lang.String ACTION_CLOSE_SYSTEM_DIALOGS
		{
			get
			{
				return "android.intent.action.CLOSE_SYSTEM_DIALOGS";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_INSTALL
		{
			get
			{
				return "android.intent.action.PACKAGE_INSTALL";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_ADDED
		{
			get
			{
				return "android.intent.action.PACKAGE_ADDED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_REPLACED
		{
			get
			{
				return "android.intent.action.PACKAGE_REPLACED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_REMOVED
		{
			get
			{
				return "android.intent.action.PACKAGE_REMOVED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_CHANGED
		{
			get
			{
				return "android.intent.action.PACKAGE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_RESTARTED
		{
			get
			{
				return "android.intent.action.PACKAGE_RESTARTED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_DATA_CLEARED
		{
			get
			{
				return "android.intent.action.PACKAGE_DATA_CLEARED";
			}
		}
		public static global::java.lang.String ACTION_UID_REMOVED
		{
			get
			{
				return "android.intent.action.UID_REMOVED";
			}
		}
		public static global::java.lang.String ACTION_EXTERNAL_APPLICATIONS_AVAILABLE
		{
			get
			{
				return "android.intent.action.EXTERNAL_APPLICATIONS_AVAILABLE";
			}
		}
		public static global::java.lang.String ACTION_EXTERNAL_APPLICATIONS_UNAVAILABLE
		{
			get
			{
				return "android.intent.action.EXTERNAL_APPLICATIONS_UNAVAILABLE";
			}
		}
		public static global::java.lang.String ACTION_WALLPAPER_CHANGED
		{
			get
			{
				return "android.intent.action.WALLPAPER_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_CONFIGURATION_CHANGED
		{
			get
			{
				return "android.intent.action.CONFIGURATION_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_LOCALE_CHANGED
		{
			get
			{
				return "android.intent.action.LOCALE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_BATTERY_CHANGED
		{
			get
			{
				return "android.intent.action.BATTERY_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_BATTERY_LOW
		{
			get
			{
				return "android.intent.action.BATTERY_LOW";
			}
		}
		public static global::java.lang.String ACTION_BATTERY_OKAY
		{
			get
			{
				return "android.intent.action.BATTERY_OKAY";
			}
		}
		public static global::java.lang.String ACTION_POWER_CONNECTED
		{
			get
			{
				return "android.intent.action.ACTION_POWER_CONNECTED";
			}
		}
		public static global::java.lang.String ACTION_POWER_DISCONNECTED
		{
			get
			{
				return "android.intent.action.ACTION_POWER_DISCONNECTED";
			}
		}
		public static global::java.lang.String ACTION_SHUTDOWN
		{
			get
			{
				return "android.intent.action.ACTION_SHUTDOWN";
			}
		}
		public static global::java.lang.String ACTION_DEVICE_STORAGE_LOW
		{
			get
			{
				return "android.intent.action.DEVICE_STORAGE_LOW";
			}
		}
		public static global::java.lang.String ACTION_DEVICE_STORAGE_OK
		{
			get
			{
				return "android.intent.action.DEVICE_STORAGE_OK";
			}
		}
		public static global::java.lang.String ACTION_MANAGE_PACKAGE_STORAGE
		{
			get
			{
				return "android.intent.action.MANAGE_PACKAGE_STORAGE";
			}
		}
		public static global::java.lang.String ACTION_UMS_CONNECTED
		{
			get
			{
				return "android.intent.action.UMS_CONNECTED";
			}
		}
		public static global::java.lang.String ACTION_UMS_DISCONNECTED
		{
			get
			{
				return "android.intent.action.UMS_DISCONNECTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_REMOVED
		{
			get
			{
				return "android.intent.action.MEDIA_REMOVED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_UNMOUNTED
		{
			get
			{
				return "android.intent.action.MEDIA_UNMOUNTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_CHECKING
		{
			get
			{
				return "android.intent.action.MEDIA_CHECKING";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_NOFS
		{
			get
			{
				return "android.intent.action.MEDIA_NOFS";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_MOUNTED
		{
			get
			{
				return "android.intent.action.MEDIA_MOUNTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SHARED
		{
			get
			{
				return "android.intent.action.MEDIA_SHARED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_BAD_REMOVAL
		{
			get
			{
				return "android.intent.action.MEDIA_BAD_REMOVAL";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_UNMOUNTABLE
		{
			get
			{
				return "android.intent.action.MEDIA_UNMOUNTABLE";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_EJECT
		{
			get
			{
				return "android.intent.action.MEDIA_EJECT";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SCANNER_STARTED
		{
			get
			{
				return "android.intent.action.MEDIA_SCANNER_STARTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SCANNER_FINISHED
		{
			get
			{
				return "android.intent.action.MEDIA_SCANNER_FINISHED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SCANNER_SCAN_FILE
		{
			get
			{
				return "android.intent.action.MEDIA_SCANNER_SCAN_FILE";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_BUTTON
		{
			get
			{
				return "android.intent.action.MEDIA_BUTTON";
			}
		}
		public static global::java.lang.String ACTION_CAMERA_BUTTON
		{
			get
			{
				return "android.intent.action.CAMERA_BUTTON";
			}
		}
		public static global::java.lang.String ACTION_GTALK_SERVICE_CONNECTED
		{
			get
			{
				return "android.intent.action.GTALK_CONNECTED";
			}
		}
		public static global::java.lang.String ACTION_GTALK_SERVICE_DISCONNECTED
		{
			get
			{
				return "android.intent.action.GTALK_DISCONNECTED";
			}
		}
		public static global::java.lang.String ACTION_INPUT_METHOD_CHANGED
		{
			get
			{
				return "android.intent.action.INPUT_METHOD_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_AIRPLANE_MODE_CHANGED
		{
			get
			{
				return "android.intent.action.AIRPLANE_MODE";
			}
		}
		public static global::java.lang.String ACTION_PROVIDER_CHANGED
		{
			get
			{
				return "android.intent.action.PROVIDER_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_HEADSET_PLUG
		{
			get
			{
				return "android.intent.action.HEADSET_PLUG";
			}
		}
		public static global::java.lang.String ACTION_NEW_OUTGOING_CALL
		{
			get
			{
				return "android.intent.action.NEW_OUTGOING_CALL";
			}
		}
		public static global::java.lang.String ACTION_REBOOT
		{
			get
			{
				return "android.intent.action.REBOOT";
			}
		}
		public static global::java.lang.String ACTION_DOCK_EVENT
		{
			get
			{
				return "android.intent.action.DOCK_EVENT";
			}
		}
		public static global::java.lang.String CATEGORY_DEFAULT
		{
			get
			{
				return "android.intent.category.DEFAULT";
			}
		}
		public static global::java.lang.String CATEGORY_BROWSABLE
		{
			get
			{
				return "android.intent.category.BROWSABLE";
			}
		}
		public static global::java.lang.String CATEGORY_ALTERNATIVE
		{
			get
			{
				return "android.intent.category.ALTERNATIVE";
			}
		}
		public static global::java.lang.String CATEGORY_SELECTED_ALTERNATIVE
		{
			get
			{
				return "android.intent.category.SELECTED_ALTERNATIVE";
			}
		}
		public static global::java.lang.String CATEGORY_TAB
		{
			get
			{
				return "android.intent.category.TAB";
			}
		}
		public static global::java.lang.String CATEGORY_LAUNCHER
		{
			get
			{
				return "android.intent.category.LAUNCHER";
			}
		}
		public static global::java.lang.String CATEGORY_INFO
		{
			get
			{
				return "android.intent.category.INFO";
			}
		}
		public static global::java.lang.String CATEGORY_HOME
		{
			get
			{
				return "android.intent.category.HOME";
			}
		}
		public static global::java.lang.String CATEGORY_PREFERENCE
		{
			get
			{
				return "android.intent.category.PREFERENCE";
			}
		}
		public static global::java.lang.String CATEGORY_DEVELOPMENT_PREFERENCE
		{
			get
			{
				return "android.intent.category.DEVELOPMENT_PREFERENCE";
			}
		}
		public static global::java.lang.String CATEGORY_EMBED
		{
			get
			{
				return "android.intent.category.EMBED";
			}
		}
		public static global::java.lang.String CATEGORY_MONKEY
		{
			get
			{
				return "android.intent.category.MONKEY";
			}
		}
		public static global::java.lang.String CATEGORY_TEST
		{
			get
			{
				return "android.intent.category.TEST";
			}
		}
		public static global::java.lang.String CATEGORY_UNIT_TEST
		{
			get
			{
				return "android.intent.category.UNIT_TEST";
			}
		}
		public static global::java.lang.String CATEGORY_SAMPLE_CODE
		{
			get
			{
				return "android.intent.category.SAMPLE_CODE";
			}
		}
		public static global::java.lang.String CATEGORY_OPENABLE
		{
			get
			{
				return "android.intent.category.OPENABLE";
			}
		}
		public static global::java.lang.String CATEGORY_FRAMEWORK_INSTRUMENTATION_TEST
		{
			get
			{
				return "android.intent.category.FRAMEWORK_INSTRUMENTATION_TEST";
			}
		}
		public static global::java.lang.String CATEGORY_CAR_DOCK
		{
			get
			{
				return "android.intent.category.CAR_DOCK";
			}
		}
		public static global::java.lang.String CATEGORY_DESK_DOCK
		{
			get
			{
				return "android.intent.category.DESK_DOCK";
			}
		}
		public static global::java.lang.String CATEGORY_CAR_MODE
		{
			get
			{
				return "android.intent.category.CAR_MODE";
			}
		}
		public static global::java.lang.String EXTRA_TEMPLATE
		{
			get
			{
				return "android.intent.extra.TEMPLATE";
			}
		}
		public static global::java.lang.String EXTRA_TEXT
		{
			get
			{
				return "android.intent.extra.TEXT";
			}
		}
		public static global::java.lang.String EXTRA_STREAM
		{
			get
			{
				return "android.intent.extra.STREAM";
			}
		}
		public static global::java.lang.String EXTRA_EMAIL
		{
			get
			{
				return "android.intent.extra.EMAIL";
			}
		}
		public static global::java.lang.String EXTRA_CC
		{
			get
			{
				return "android.intent.extra.CC";
			}
		}
		public static global::java.lang.String EXTRA_BCC
		{
			get
			{
				return "android.intent.extra.BCC";
			}
		}
		public static global::java.lang.String EXTRA_SUBJECT
		{
			get
			{
				return "android.intent.extra.SUBJECT";
			}
		}
		public static global::java.lang.String EXTRA_INTENT
		{
			get
			{
				return "android.intent.extra.INTENT";
			}
		}
		public static global::java.lang.String EXTRA_TITLE
		{
			get
			{
				return "android.intent.extra.TITLE";
			}
		}
		public static global::java.lang.String EXTRA_INITIAL_INTENTS
		{
			get
			{
				return "android.intent.extra.INITIAL_INTENTS";
			}
		}
		public static global::java.lang.String EXTRA_KEY_EVENT
		{
			get
			{
				return "android.intent.extra.KEY_EVENT";
			}
		}
		public static global::java.lang.String EXTRA_DONT_KILL_APP
		{
			get
			{
				return "android.intent.extra.DONT_KILL_APP";
			}
		}
		public static global::java.lang.String EXTRA_PHONE_NUMBER
		{
			get
			{
				return "android.intent.extra.PHONE_NUMBER";
			}
		}
		public static global::java.lang.String EXTRA_UID
		{
			get
			{
				return "android.intent.extra.UID";
			}
		}
		public static global::java.lang.String EXTRA_DATA_REMOVED
		{
			get
			{
				return "android.intent.extra.DATA_REMOVED";
			}
		}
		public static global::java.lang.String EXTRA_REPLACING
		{
			get
			{
				return "android.intent.extra.REPLACING";
			}
		}
		public static global::java.lang.String EXTRA_ALARM_COUNT
		{
			get
			{
				return "android.intent.extra.ALARM_COUNT";
			}
		}
		public static global::java.lang.String EXTRA_DOCK_STATE
		{
			get
			{
				return "android.intent.extra.DOCK_STATE";
			}
		}
		public static int EXTRA_DOCK_STATE_UNDOCKED
		{
			get
			{
				return 0;
			}
		}
		public static int EXTRA_DOCK_STATE_DESK
		{
			get
			{
				return 1;
			}
		}
		public static int EXTRA_DOCK_STATE_CAR
		{
			get
			{
				return 2;
			}
		}
		public static global::java.lang.String METADATA_DOCK_HOME
		{
			get
			{
				return "android.dock_home";
			}
		}
		public static global::java.lang.String EXTRA_REMOTE_INTENT_TOKEN
		{
			get
			{
				return "android.intent.extra.remote_intent_token";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_COMPONENT_NAME
		{
			get
			{
				return "android.intent.extra.changed_component_name";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_COMPONENT_NAME_LIST
		{
			get
			{
				return "android.intent.extra.changed_component_name_list";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_PACKAGE_LIST
		{
			get
			{
				return "android.intent.extra.changed_package_list";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_UID_LIST
		{
			get
			{
				return "android.intent.extra.changed_uid_list";
			}
		}
		public static int FLAG_GRANT_READ_URI_PERMISSION
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_GRANT_WRITE_URI_PERMISSION
		{
			get
			{
				return 2;
			}
		}
		public static int FLAG_FROM_BACKGROUND
		{
			get
			{
				return 4;
			}
		}
		public static int FLAG_DEBUG_LOG_RESOLUTION
		{
			get
			{
				return 8;
			}
		}
		public static int FLAG_ACTIVITY_NO_HISTORY
		{
			get
			{
				return 1073741824;
			}
		}
		public static int FLAG_ACTIVITY_SINGLE_TOP
		{
			get
			{
				return 536870912;
			}
		}
		public static int FLAG_ACTIVITY_NEW_TASK
		{
			get
			{
				return 268435456;
			}
		}
		public static int FLAG_ACTIVITY_MULTIPLE_TASK
		{
			get
			{
				return 134217728;
			}
		}
		public static int FLAG_ACTIVITY_CLEAR_TOP
		{
			get
			{
				return 67108864;
			}
		}
		public static int FLAG_ACTIVITY_FORWARD_RESULT
		{
			get
			{
				return 33554432;
			}
		}
		public static int FLAG_ACTIVITY_PREVIOUS_IS_TOP
		{
			get
			{
				return 16777216;
			}
		}
		public static int FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS
		{
			get
			{
				return 8388608;
			}
		}
		public static int FLAG_ACTIVITY_BROUGHT_TO_FRONT
		{
			get
			{
				return 4194304;
			}
		}
		public static int FLAG_ACTIVITY_RESET_TASK_IF_NEEDED
		{
			get
			{
				return 2097152;
			}
		}
		public static int FLAG_ACTIVITY_LAUNCHED_FROM_HISTORY
		{
			get
			{
				return 1048576;
			}
		}
		public static int FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET
		{
			get
			{
				return 524288;
			}
		}
		public static int FLAG_ACTIVITY_NO_USER_ACTION
		{
			get
			{
				return 262144;
			}
		}
		public static int FLAG_ACTIVITY_REORDER_TO_FRONT
		{
			get
			{
				return 131072;
			}
		}
		public static int FLAG_ACTIVITY_NO_ANIMATION
		{
			get
			{
				return 65536;
			}
		}
		public static int FLAG_RECEIVER_REGISTERED_ONLY
		{
			get
			{
				return 1073741824;
			}
		}
		public static int FLAG_RECEIVER_REPLACE_PENDING
		{
			get
			{
				return 536870912;
			}
		}
		public static int URI_INTENT_SCHEME
		{
			get
			{
				return 1;
			}
		}
		public static int FILL_IN_ACTION
		{
			get
			{
				return 1;
			}
		}
		public static int FILL_IN_DATA
		{
			get
			{
				return 2;
			}
		}
		public static int FILL_IN_CATEGORIES
		{
			get
			{
				return 4;
			}
		}
		public static int FILL_IN_COMPONENT
		{
			get
			{
				return 8;
			}
		}
		public static int FILL_IN_PACKAGE
		{
			get
			{
				return 16;
			}
		}
		public static int FILL_IN_SOURCE_BOUNDS
		{
			get
			{
				return 32;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3396;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.Intent.staticClass, _CREATOR3396)) as android.os.Parcelable_Creator;
			}
		}
		static Intent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Intent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Intent"));
			global::android.content.Intent._CREATOR3396 = @__env.GetStaticFieldIDNoThrow(global::android.content.Intent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
