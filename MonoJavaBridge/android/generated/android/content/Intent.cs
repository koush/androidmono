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
			private static global::MonoJavaBridge.MethodId _m0;
			public sealed override bool equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.FilterComparison.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.Intent.FilterComparison._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public sealed override int hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.FilterComparison.staticClass, "hashCode", "()I", ref global::android.content.Intent.FilterComparison._m1);
			}
			public new global::android.content.Intent Intent
			{
				get
				{
					return getIntent();
				}
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public global::android.content.Intent getIntent()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.FilterComparison.staticClass, "getIntent", "()Landroid/content/Intent;", ref global::android.content.Intent.FilterComparison._m2) as android.content.Intent;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public FilterComparison(android.content.Intent arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.Intent.FilterComparison._m3.native == global::System.IntPtr.Zero)
					global::android.content.Intent.FilterComparison._m3 = @__env.GetMethodIDNoThrow(global::android.content.Intent.FilterComparison.staticClass, "<init>", "(Landroid/content/Intent;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.FilterComparison.staticClass, global::android.content.Intent.FilterComparison._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.ShortcutIconResource.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.Intent.ShortcutIconResource._m0) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.ShortcutIconResource.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.Intent.ShortcutIconResource._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual int describeContents()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.ShortcutIconResource.staticClass, "describeContents", "()I", ref global::android.content.Intent.ShortcutIconResource._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public static global::android.content.Intent.ShortcutIconResource fromContext(android.content.Context arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.Intent.ShortcutIconResource._m3.native == global::System.IntPtr.Zero)
					global::android.content.Intent.ShortcutIconResource._m3 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "fromContext", "(Landroid/content/Context;I)Landroid/content/Intent$ShortcutIconResource;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent.ShortcutIconResource;
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public ShortcutIconResource() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.Intent.ShortcutIconResource._m4.native == global::System.IntPtr.Zero)
					global::android.content.Intent.ShortcutIconResource._m4 = @__env.GetMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._m4);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _packageName1683;
			public global::java.lang.String packageName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName1683)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _resourceName1684;
			public global::java.lang.String resourceName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _resourceName1684)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1685;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.Intent.ShortcutIconResource.staticClass, _CREATOR1685)) as android.os.Parcelable_Creator;
				}
			}
			static ShortcutIconResource()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.Intent.ShortcutIconResource.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Intent$ShortcutIconResource"));
				global::android.content.Intent.ShortcutIconResource._packageName1683 = @__env.GetFieldIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "packageName", "Ljava/lang/String;");
				global::android.content.Intent.ShortcutIconResource._resourceName1684 = @__env.GetFieldIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "resourceName", "Ljava/lang/String;");
				global::android.content.Intent.ShortcutIconResource._CREATOR1685 = @__env.GetStaticFieldIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.Intent._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "clone", "()Ljava/lang/Object;", ref global::android.content.Intent._m1) as java.lang.Object;
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
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getPackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getPackage", "()Ljava/lang/String;", ref global::android.content.Intent._m2) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getType", "()Ljava/lang/String;", ref global::android.content.Intent._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String toURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "toURI", "()Ljava/lang/String;", ref global::android.content.Intent._m4) as java.lang.String;
		}
		public new global::java.lang.String Scheme
		{
			get
			{
				return getScheme();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getScheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getScheme", "()Ljava/lang/String;", ref global::android.content.Intent._m5) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.net.Uri getData()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "getData", "()Landroid/net/Uri;", ref global::android.content.Intent._m6) as android.net.Uri;
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
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.content.ComponentName getComponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.content.Intent.staticClass, "getComponent", "()Landroid/content/ComponentName;", ref global::android.content.Intent._m7) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.content.Intent setClassName(android.content.Context arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setClassName", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.content.Intent setClassName(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setClassName", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.Intent._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.staticClass, "describeContents", "()I", ref global::android.content.Intent._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::android.content.Intent createChooser(android.content.Intent arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._m12.native == global::System.IntPtr.Zero)
				global::android.content.Intent._m12 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "createChooser", "(Landroid/content/Intent;Ljava/lang/CharSequence;)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		public static android.content.Intent createChooser(android.content.Intent arg0, string arg1)
		{
			return createChooser(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.content.Intent cloneFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "cloneFilter", "()Landroid/content/Intent;", ref global::android.content.Intent._m13) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::android.content.Intent getIntent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._m14.native == global::System.IntPtr.Zero)
				global::android.content.Intent._m14 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntent", "(Ljava/lang/String;)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::android.content.Intent parseUri(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._m15.native == global::System.IntPtr.Zero)
				global::android.content.Intent._m15 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "parseUri", "(Ljava/lang/String;I)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::android.content.Intent getIntentOld(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._m16.native == global::System.IntPtr.Zero)
				global::android.content.Intent._m16 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntentOld", "(Ljava/lang/String;)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
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
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.String getAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getAction", "()Ljava/lang/String;", ref global::android.content.Intent._m17) as java.lang.String;
		}
		public new global::java.lang.String DataString
		{
			get
			{
				return getDataString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.String getDataString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getDataString", "()Ljava/lang/String;", ref global::android.content.Intent._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.lang.String resolveType(android.content.Context arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "resolveType", "(Landroid/content/Context;)Ljava/lang/String;", ref global::android.content.Intent._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.String resolveType(android.content.ContentResolver arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "resolveType", "(Landroid/content/ContentResolver;)Ljava/lang/String;", ref global::android.content.Intent._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.lang.String resolveTypeIfNeeded(android.content.ContentResolver arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "resolveTypeIfNeeded", "(Landroid/content/ContentResolver;)Ljava/lang/String;", ref global::android.content.Intent._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool hasCategory(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.staticClass, "hasCategory", "(Ljava/lang/String;)Z", ref global::android.content.Intent._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Set Categories
		{
			get
			{
				return getCategories();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.util.Set getCategories()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.content.Intent.staticClass, "getCategories", "()Ljava/util/Set;", ref global::android.content.Intent._m23) as java.util.Set;
		}
		public new global::java.lang.ClassLoader ExtrasClassLoader
		{
			set
			{
				setExtrasClassLoader(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setExtrasClassLoader(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "setExtrasClassLoader", "(Ljava/lang/ClassLoader;)V", ref global::android.content.Intent._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool hasExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.staticClass, "hasExtra", "(Ljava/lang/String;)Z", ref global::android.content.Intent._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool hasFileDescriptors()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.staticClass, "hasFileDescriptors", "()Z", ref global::android.content.Intent._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool getBooleanExtra(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.staticClass, "getBooleanExtra", "(Ljava/lang/String;Z)Z", ref global::android.content.Intent._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual byte getByteExtra(java.lang.String arg0, byte arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::android.content.Intent.staticClass, "getByteExtra", "(Ljava/lang/String;B)B", ref global::android.content.Intent._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual short getShortExtra(java.lang.String arg0, short arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.content.Intent.staticClass, "getShortExtra", "(Ljava/lang/String;S)S", ref global::android.content.Intent._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual char getCharExtra(java.lang.String arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.content.Intent.staticClass, "getCharExtra", "(Ljava/lang/String;C)C", ref global::android.content.Intent._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual int getIntExtra(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.staticClass, "getIntExtra", "(Ljava/lang/String;I)I", ref global::android.content.Intent._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual long getLongExtra(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.Intent.staticClass, "getLongExtra", "(Ljava/lang/String;J)J", ref global::android.content.Intent._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual float getFloatExtra(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.Intent.staticClass, "getFloatExtra", "(Ljava/lang/String;F)F", ref global::android.content.Intent._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual double getDoubleExtra(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.content.Intent.staticClass, "getDoubleExtra", "(Ljava/lang/String;D)D", ref global::android.content.Intent._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::java.lang.String getStringExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getStringExtra", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.content.Intent._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual global::java.lang.CharSequence getCharSequenceExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.Intent.staticClass, "getCharSequenceExtra", "(Ljava/lang/String;)Ljava/lang/CharSequence;", ref global::android.content.Intent._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::android.os.Parcelable getParcelableExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.content.Intent.staticClass, "getParcelableExtra", "(Ljava/lang/String;)Landroid/os/Parcelable;", ref global::android.content.Intent._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::android.os.Parcelable[] getParcelableArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.os.Parcelable>(this, global::android.content.Intent.staticClass, "getParcelableArrayExtra", "(Ljava/lang/String;)[Landroid/os/Parcelable;", ref global::android.content.Intent._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Parcelable[];
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual global::java.util.ArrayList getParcelableArrayListExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "getParcelableArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.content.Intent._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::java.io.Serializable getSerializableExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.io.Serializable>(this, global::android.content.Intent.staticClass, "getSerializableExtra", "(Ljava/lang/String;)Ljava/io/Serializable;", ref global::android.content.Intent._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Serializable;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual global::java.util.ArrayList getIntegerArrayListExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "getIntegerArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.content.Intent._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::java.util.ArrayList getStringArrayListExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "getStringArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.content.Intent._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual global::java.util.ArrayList getCharSequenceArrayListExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "getCharSequenceArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.content.Intent._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual bool[] getBooleanArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::android.content.Intent.staticClass, "getBooleanArrayExtra", "(Ljava/lang/String;)[Z", ref global::android.content.Intent._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as bool[];
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual byte[] getByteArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.content.Intent.staticClass, "getByteArrayExtra", "(Ljava/lang/String;)[B", ref global::android.content.Intent._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual short[] getShortArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<short>(this, global::android.content.Intent.staticClass, "getShortArrayExtra", "(Ljava/lang/String;)[S", ref global::android.content.Intent._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as short[];
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual char[] getCharArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.content.Intent.staticClass, "getCharArrayExtra", "(Ljava/lang/String;)[C", ref global::android.content.Intent._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual int[] getIntArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.content.Intent.staticClass, "getIntArrayExtra", "(Ljava/lang/String;)[I", ref global::android.content.Intent._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual long[] getLongArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<long>(this, global::android.content.Intent.staticClass, "getLongArrayExtra", "(Ljava/lang/String;)[J", ref global::android.content.Intent._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as long[];
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual float[] getFloatArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<float>(this, global::android.content.Intent.staticClass, "getFloatArrayExtra", "(Ljava/lang/String;)[F", ref global::android.content.Intent._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as float[];
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual double[] getDoubleArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<double>(this, global::android.content.Intent.staticClass, "getDoubleArrayExtra", "(Ljava/lang/String;)[D", ref global::android.content.Intent._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as double[];
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public virtual global::java.lang.String[] getStringArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "getStringArrayExtra", "(Ljava/lang/String;)[Ljava/lang/String;", ref global::android.content.Intent._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual global::java.lang.CharSequence[] getCharSequenceArrayExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.CharSequence>(this, global::android.content.Intent.staticClass, "getCharSequenceArrayExtra", "(Ljava/lang/String;)[Ljava/lang/CharSequence;", ref global::android.content.Intent._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence[];
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual global::android.os.Bundle getBundleExtra(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.content.Intent.staticClass, "getBundleExtra", "(Ljava/lang/String;)Landroid/os/Bundle;", ref global::android.content.Intent._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual global::android.os.Bundle getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.content.Intent.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.content.Intent._m55) as android.os.Bundle;
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
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual int getFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.staticClass, "getFlags", "()I", ref global::android.content.Intent._m56);
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
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual global::android.graphics.Rect getSourceBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Rect>(this, global::android.content.Intent.staticClass, "getSourceBounds", "()Landroid/graphics/Rect;", ref global::android.content.Intent._m57) as android.graphics.Rect;
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual global::android.content.ComponentName resolveActivity(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.content.Intent.staticClass, "resolveActivity", "(Landroid/content/pm/PackageManager;)Landroid/content/ComponentName;", ref global::android.content.Intent._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual global::android.content.pm.ActivityInfo resolveActivityInfo(android.content.pm.PackageManager arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "resolveActivityInfo", "(Landroid/content/pm/PackageManager;I)Landroid/content/pm/ActivityInfo;", ref global::android.content.Intent._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.ActivityInfo;
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual global::android.content.Intent setAction(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setAction", "(Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual global::android.content.Intent setData(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setData", "(Landroid/net/Uri;)Landroid/content/Intent;", ref global::android.content.Intent._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public virtual global::android.content.Intent setType(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setType", "(Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public virtual global::android.content.Intent setDataAndType(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setDataAndType", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public virtual global::android.content.Intent addCategory(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "addCategory", "(Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual void removeCategory(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "removeCategory", "(Ljava/lang/String;)V", ref global::android.content.Intent._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, bool[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Z)Landroid/content/Intent;", ref global::android.content.Intent._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Z)Landroid/content/Intent;", ref global::android.content.Intent._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, byte arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;B)Landroid/content/Intent;", ref global::android.content.Intent._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;C)Landroid/content/Intent;", ref global::android.content.Intent._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, short arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;S)Landroid/content/Intent;", ref global::android.content.Intent._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;I)Landroid/content/Intent;", ref global::android.content.Intent._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;J)Landroid/content/Intent;", ref global::android.content.Intent._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;F)Landroid/content/Intent;", ref global::android.content.Intent._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;D)Landroid/content/Intent;", ref global::android.content.Intent._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/lang/CharSequence;)Landroid/content/Intent;", ref global::android.content.Intent._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		public android.content.Intent putExtra(java.lang.String arg0, string arg1)
		{
			return putExtra(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Parcelable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Landroid/os/Parcelable;)Landroid/content/Intent;", ref global::android.content.Intent._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Parcelable[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Landroid/os/Parcelable;)Landroid/content/Intent;", ref global::android.content.Intent._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.io.Serializable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;", ref global::android.content.Intent._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, byte[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[B)Landroid/content/Intent;", ref global::android.content.Intent._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, short[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[S)Landroid/content/Intent;", ref global::android.content.Intent._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, char[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[C)Landroid/content/Intent;", ref global::android.content.Intent._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[I)Landroid/content/Intent;", ref global::android.content.Intent._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, long[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[J)Landroid/content/Intent;", ref global::android.content.Intent._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, float[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[F)Landroid/content/Intent;", ref global::android.content.Intent._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m86;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, double[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[D)Landroid/content/Intent;", ref global::android.content.Intent._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m87;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m88;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.CharSequence[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Ljava/lang/CharSequence;)Landroid/content/Intent;", ref global::android.content.Intent._m88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m89;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Bundle arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;", ref global::android.content.Intent._m89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m90;
		public virtual global::android.content.Intent putParcelableArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putParcelableArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", ref global::android.content.Intent._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m91;
		public virtual global::android.content.Intent putIntegerArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putIntegerArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", ref global::android.content.Intent._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m92;
		public virtual global::android.content.Intent putStringArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putStringArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", ref global::android.content.Intent._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m93;
		public virtual global::android.content.Intent putCharSequenceArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putCharSequenceArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", ref global::android.content.Intent._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m94;
		public virtual global::android.content.Intent putExtras(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;", ref global::android.content.Intent._m94, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m95;
		public virtual global::android.content.Intent putExtras(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "putExtras", "(Landroid/content/Intent;)Landroid/content/Intent;", ref global::android.content.Intent._m95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m96;
		public virtual global::android.content.Intent replaceExtras(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "replaceExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;", ref global::android.content.Intent._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m97;
		public virtual global::android.content.Intent replaceExtras(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "replaceExtras", "(Landroid/content/Intent;)Landroid/content/Intent;", ref global::android.content.Intent._m97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m98;
		public virtual void removeExtra(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "removeExtra", "(Ljava/lang/String;)V", ref global::android.content.Intent._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		public virtual global::android.content.Intent setFlags(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setFlags", "(I)Landroid/content/Intent;", ref global::android.content.Intent._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m100;
		public virtual global::android.content.Intent addFlags(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "addFlags", "(I)Landroid/content/Intent;", ref global::android.content.Intent._m100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m101;
		public virtual global::android.content.Intent setPackage(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setPackage", "(Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.Intent._m101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m102;
		public virtual global::android.content.Intent setComponent(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setComponent", "(Landroid/content/ComponentName;)Landroid/content/Intent;", ref global::android.content.Intent._m102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m103;
		public virtual global::android.content.Intent setClass(android.content.Context arg0, java.lang.Class arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Intent.staticClass, "setClass", "(Landroid/content/Context;Ljava/lang/Class;)Landroid/content/Intent;", ref global::android.content.Intent._m103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m104;
		public virtual void setSourceBounds(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "setSourceBounds", "(Landroid/graphics/Rect;)V", ref global::android.content.Intent._m104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m105;
		public virtual int fillIn(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.staticClass, "fillIn", "(Landroid/content/Intent;I)I", ref global::android.content.Intent._m105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m106;
		public virtual bool filterEquals(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Intent.staticClass, "filterEquals", "(Landroid/content/Intent;)Z", ref global::android.content.Intent._m106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m107;
		public virtual int filterHashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Intent.staticClass, "filterHashCode", "()I", ref global::android.content.Intent._m107);
		}
		private static global::MonoJavaBridge.MethodId _m108;
		public virtual global::java.lang.String toUri(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Intent.staticClass, "toUri", "(I)Ljava/lang/String;", ref global::android.content.Intent._m108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m109;
		public virtual void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Intent.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.content.Intent._m109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m110;
		public static global::android.content.Intent parseIntent(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._m110.native == global::System.IntPtr.Zero)
				global::android.content.Intent._m110 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "parseIntent", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._m110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m111;
		public Intent() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._m111.native == global::System.IntPtr.Zero)
				global::android.content.Intent._m111 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._m111);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m112;
		public Intent(android.content.Intent arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._m112.native == global::System.IntPtr.Zero)
				global::android.content.Intent._m112 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Landroid/content/Intent;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._m112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m113;
		public Intent(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._m113.native == global::System.IntPtr.Zero)
				global::android.content.Intent._m113 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._m113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m114;
		public Intent(java.lang.String arg0, android.net.Uri arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._m114.native == global::System.IntPtr.Zero)
				global::android.content.Intent._m114 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/Uri;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._m114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m115;
		public Intent(android.content.Context arg0, java.lang.Class arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._m115.native == global::System.IntPtr.Zero)
				global::android.content.Intent._m115 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._m115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m116;
		public Intent(java.lang.String arg0, android.net.Uri arg1, android.content.Context arg2, java.lang.Class arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Intent._m116.native == global::System.IntPtr.Zero)
				global::android.content.Intent._m116 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/Uri;Landroid/content/Context;Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._m116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR1853;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.Intent.staticClass, _CREATOR1853)) as android.os.Parcelable_Creator;
			}
		}
		static Intent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Intent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Intent"));
			global::android.content.Intent._CREATOR1853 = @__env.GetStaticFieldIDNoThrow(global::android.content.Intent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
