namespace android.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.net.Uri_))]
	public abstract partial class Uri : java.lang.Object, android.os.Parcelable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Uri(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Builder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Builder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public sealed override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri.Builder.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.Uri.Builder._m0) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public global::android.net.Uri.Builder path(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "path", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public global::android.net.Uri.Builder query(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "query", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public global::android.net.Uri.Builder authority(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "authority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public global::android.net.Uri.Builder scheme(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "scheme", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public global::android.net.Uri.Builder fragment(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "fragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public global::android.net.Uri build()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.Uri.Builder.staticClass, "build", "()Landroid/net/Uri;", ref global::android.net.Uri.Builder._m6) as android.net.Uri;
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public global::android.net.Uri.Builder opaquePart(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "opaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public global::android.net.Uri.Builder encodedOpaquePart(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "encodedOpaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public global::android.net.Uri.Builder encodedAuthority(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "encodedAuthority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public global::android.net.Uri.Builder encodedPath(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "encodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m11;
			public global::android.net.Uri.Builder appendPath(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "appendPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m12;
			public global::android.net.Uri.Builder appendEncodedPath(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "appendEncodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m13;
			public global::android.net.Uri.Builder encodedQuery(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "encodedQuery", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m14;
			public global::android.net.Uri.Builder encodedFragment(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "encodedFragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m15;
			public global::android.net.Uri.Builder appendQueryParameter(java.lang.String arg0, java.lang.String arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "appendQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.net.Uri.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m16;
			public Builder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.Uri.Builder._m16.native == global::System.IntPtr.Zero)
					global::android.net.Uri.Builder._m16 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._m16);
				Init(@__env, handle);
			}
			static Builder()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.Uri.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri$Builder"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void writeToParcel(android.os.Parcel arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract int describeContents();
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.Uri.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.net.Uri._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.lang.String toString();
		private static global::MonoJavaBridge.MethodId _m4;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Uri.staticClass, "hashCode", "()I", ref global::android.net.Uri._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int compareTo(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Uri.staticClass, "compareTo", "(Landroid/net/Uri;)I", ref global::android.net.Uri._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Uri.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::android.net.Uri._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.String decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._m7.native == global::System.IntPtr.Zero)
				global::android.net.Uri._m7 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.String encode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._m8.native == global::System.IntPtr.Zero)
				global::android.net.Uri._m8 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.String encode(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._m9.native == global::System.IntPtr.Zero)
				global::android.net.Uri._m9 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isAbsolute()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.Uri.staticClass, "isAbsolute", "()Z", ref global::android.net.Uri._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract global::java.lang.String getPath();
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isOpaque()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.Uri.staticClass, "isOpaque", "()Z", ref global::android.net.Uri._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract global::java.lang.String getScheme();
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract global::java.lang.String getAuthority();
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract global::java.lang.String getFragment();
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract global::java.lang.String getQuery();
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::android.net.Uri parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._m17.native == global::System.IntPtr.Zero)
				global::android.net.Uri._m17 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "parse", "(Ljava/lang/String;)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract global::java.lang.String getUserInfo();
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract int getPort();
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract global::java.lang.String getHost();
		private static global::MonoJavaBridge.MethodId _m21;
		public static void writeToParcel(android.os.Parcel arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._m21.native == global::System.IntPtr.Zero)
				global::android.net.Uri._m21 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "writeToParcel", "(Landroid/os/Parcel;Landroid/net/Uri;)V");
			@__env.CallStaticVoidMethod(android.net.Uri.staticClass, global::android.net.Uri._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract bool isHierarchical();
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract bool isRelative();
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract global::java.lang.String getSchemeSpecificPart();
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract global::java.lang.String getEncodedSchemeSpecificPart();
		private static global::MonoJavaBridge.MethodId _m26;
		public abstract global::java.lang.String getEncodedAuthority();
		private static global::MonoJavaBridge.MethodId _m27;
		public abstract global::java.lang.String getEncodedUserInfo();
		private static global::MonoJavaBridge.MethodId _m28;
		public abstract global::java.lang.String getEncodedPath();
		private static global::MonoJavaBridge.MethodId _m29;
		public abstract global::java.lang.String getEncodedQuery();
		private static global::MonoJavaBridge.MethodId _m30;
		public abstract global::java.lang.String getEncodedFragment();
		private static global::MonoJavaBridge.MethodId _m31;
		public abstract global::java.util.List getPathSegments();
		private static global::MonoJavaBridge.MethodId _m32;
		public abstract global::java.lang.String getLastPathSegment();
		private static global::MonoJavaBridge.MethodId _m33;
		public abstract global::android.net.Uri.Builder buildUpon();
		private static global::MonoJavaBridge.MethodId _m34;
		public static global::android.net.Uri fromFile(java.io.File arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._m34.native == global::System.IntPtr.Zero)
				global::android.net.Uri._m34 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "fromFile", "(Ljava/io/File;)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static global::android.net.Uri fromParts(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._m35.native == global::System.IntPtr.Zero)
				global::android.net.Uri._m35 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "fromParts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual global::java.util.List getQueryParameters(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.net.Uri.staticClass, "getQueryParameters", "(Ljava/lang/String;)Ljava/util/List;", ref global::android.net.Uri._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::java.lang.String getQueryParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri.staticClass, "getQueryParameter", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.net.Uri._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static global::android.net.Uri withAppendedPath(android.net.Uri arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._m38.native == global::System.IntPtr.Zero)
				global::android.net.Uri._m38 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "withAppendedPath", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY2993;
		public static global::android.net.Uri EMPTY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.net.Uri.staticClass, _EMPTY2993)) as android.net.Uri;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2994;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.net.Uri.staticClass, _CREATOR2994)) as android.os.Parcelable_Creator;
			}
		}
		static Uri()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Uri.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri"));
			global::android.net.Uri._EMPTY2993 = @__env.GetStaticFieldIDNoThrow(global::android.net.Uri.staticClass, "EMPTY", "Landroid/net/Uri;");
			global::android.net.Uri._CREATOR2994 = @__env.GetStaticFieldIDNoThrow(global::android.net.Uri.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.net.Uri))]
	internal sealed partial class Uri_ : android.net.Uri
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Uri_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.Uri_.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.net.Uri_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Uri_.staticClass, "describeContents", "()I", ref global::android.net.Uri_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.Uri_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getPath", "()Ljava/lang/String;", ref global::android.net.Uri_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String getScheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getScheme", "()Ljava/lang/String;", ref global::android.net.Uri_._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.lang.String getAuthority()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getAuthority", "()Ljava/lang/String;", ref global::android.net.Uri_._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.lang.String getFragment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getFragment", "()Ljava/lang/String;", ref global::android.net.Uri_._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.lang.String getQuery()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getQuery", "()Ljava/lang/String;", ref global::android.net.Uri_._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.lang.String getUserInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getUserInfo", "()Ljava/lang/String;", ref global::android.net.Uri_._m8) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Uri_.staticClass, "getPort", "()I", ref global::android.net.Uri_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.String getHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getHost", "()Ljava/lang/String;", ref global::android.net.Uri_._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool isHierarchical()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.Uri_.staticClass, "isHierarchical", "()Z", ref global::android.net.Uri_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override bool isRelative()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.Uri_.staticClass, "isRelative", "()Z", ref global::android.net.Uri_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::java.lang.String getSchemeSpecificPart()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;", ref global::android.net.Uri_._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::java.lang.String getEncodedSchemeSpecificPart()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedSchemeSpecificPart", "()Ljava/lang/String;", ref global::android.net.Uri_._m14) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::java.lang.String getEncodedAuthority()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedAuthority", "()Ljava/lang/String;", ref global::android.net.Uri_._m15) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::java.lang.String getEncodedUserInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedUserInfo", "()Ljava/lang/String;", ref global::android.net.Uri_._m16) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::java.lang.String getEncodedPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedPath", "()Ljava/lang/String;", ref global::android.net.Uri_._m17) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::java.lang.String getEncodedQuery()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedQuery", "()Ljava/lang/String;", ref global::android.net.Uri_._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override global::java.lang.String getEncodedFragment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedFragment", "()Ljava/lang/String;", ref global::android.net.Uri_._m19) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override global::java.util.List getPathSegments()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.net.Uri_.staticClass, "getPathSegments", "()Ljava/util/List;", ref global::android.net.Uri_._m20) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override global::java.lang.String getLastPathSegment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getLastPathSegment", "()Ljava/lang/String;", ref global::android.net.Uri_._m21) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override global::android.net.Uri.Builder buildUpon()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri_.staticClass, "buildUpon", "()Landroid/net/Uri$Builder;", ref global::android.net.Uri_._m22) as android.net.Uri.Builder;
		}
		static Uri_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Uri_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri"));
		}
	}
}
