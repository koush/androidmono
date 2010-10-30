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
			internal static global::MonoJavaBridge.MethodId _toString7780;
			public sealed override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri.Builder.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.Uri.Builder._toString7780) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _path7781;
			public global::android.net.Uri.Builder path(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "path", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._path7781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _query7782;
			public global::android.net.Uri.Builder query(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "query", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._query7782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _authority7783;
			public global::android.net.Uri.Builder authority(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "authority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._authority7783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _scheme7784;
			public global::android.net.Uri.Builder scheme(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "scheme", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._scheme7784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _fragment7785;
			public global::android.net.Uri.Builder fragment(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "fragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._fragment7785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _build7786;
			public global::android.net.Uri build()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.Uri.Builder.staticClass, "build", "()Landroid/net/Uri;", ref global::android.net.Uri.Builder._build7786) as android.net.Uri;
			}
			internal static global::MonoJavaBridge.MethodId _opaquePart7787;
			public global::android.net.Uri.Builder opaquePart(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "opaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._opaquePart7787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedOpaquePart7788;
			public global::android.net.Uri.Builder encodedOpaquePart(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "encodedOpaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._encodedOpaquePart7788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedAuthority7789;
			public global::android.net.Uri.Builder encodedAuthority(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "encodedAuthority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._encodedAuthority7789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedPath7790;
			public global::android.net.Uri.Builder encodedPath(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "encodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._encodedPath7790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _appendPath7791;
			public global::android.net.Uri.Builder appendPath(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "appendPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._appendPath7791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _appendEncodedPath7792;
			public global::android.net.Uri.Builder appendEncodedPath(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "appendEncodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._appendEncodedPath7792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedQuery7793;
			public global::android.net.Uri.Builder encodedQuery(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "encodedQuery", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._encodedQuery7793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedFragment7794;
			public global::android.net.Uri.Builder encodedFragment(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "encodedFragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._encodedFragment7794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _appendQueryParameter7795;
			public global::android.net.Uri.Builder appendQueryParameter(java.lang.String arg0, java.lang.String arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri.Builder.staticClass, "appendQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri$Builder;", ref global::android.net.Uri.Builder._appendQueryParameter7795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _Builder7796;
			public Builder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.Uri.Builder._Builder7796.native == global::System.IntPtr.Zero)
					global::android.net.Uri.Builder._Builder7796 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._Builder7796);
				Init(@__env, handle);
			}
			static Builder()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.Uri.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri$Builder"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7797;
		public abstract void writeToParcel(android.os.Parcel arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _describeContents7798;
		public abstract int describeContents();
		internal static global::MonoJavaBridge.MethodId _equals7799;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.Uri.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.net.Uri._equals7799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString7800;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode7801;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Uri.staticClass, "hashCode", "()I", ref global::android.net.Uri._hashCode7801);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo7802;
		public virtual int compareTo(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Uri.staticClass, "compareTo", "(Landroid/net/Uri;)I", ref global::android.net.Uri._compareTo7802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo7803;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Uri.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::android.net.Uri._compareTo7803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decode7804;
		public static global::java.lang.String decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._decode7804.native == global::System.IntPtr.Zero)
				global::android.net.Uri._decode7804 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._decode7804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _encode7805;
		public static global::java.lang.String encode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._encode7805.native == global::System.IntPtr.Zero)
				global::android.net.Uri._encode7805 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._encode7805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _encode7806;
		public static global::java.lang.String encode(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._encode7806.native == global::System.IntPtr.Zero)
				global::android.net.Uri._encode7806 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._encode7806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAbsolute7807;
		public virtual bool isAbsolute()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.Uri.staticClass, "isAbsolute", "()Z", ref global::android.net.Uri._isAbsolute7807);
		}
		internal static global::MonoJavaBridge.MethodId _getPath7808;
		public abstract global::java.lang.String getPath();
		internal static global::MonoJavaBridge.MethodId _isOpaque7809;
		public virtual bool isOpaque()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.Uri.staticClass, "isOpaque", "()Z", ref global::android.net.Uri._isOpaque7809);
		}
		internal static global::MonoJavaBridge.MethodId _getScheme7810;
		public abstract global::java.lang.String getScheme();
		internal static global::MonoJavaBridge.MethodId _getAuthority7811;
		public abstract global::java.lang.String getAuthority();
		internal static global::MonoJavaBridge.MethodId _getFragment7812;
		public abstract global::java.lang.String getFragment();
		internal static global::MonoJavaBridge.MethodId _getQuery7813;
		public abstract global::java.lang.String getQuery();
		internal static global::MonoJavaBridge.MethodId _parse7814;
		public static global::android.net.Uri parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._parse7814.native == global::System.IntPtr.Zero)
				global::android.net.Uri._parse7814 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "parse", "(Ljava/lang/String;)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._parse7814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo7815;
		public abstract global::java.lang.String getUserInfo();
		internal static global::MonoJavaBridge.MethodId _getPort7816;
		public abstract int getPort();
		internal static global::MonoJavaBridge.MethodId _getHost7817;
		public abstract global::java.lang.String getHost();
		internal static global::MonoJavaBridge.MethodId _writeToParcel7818;
		public static void writeToParcel(android.os.Parcel arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._writeToParcel7818.native == global::System.IntPtr.Zero)
				global::android.net.Uri._writeToParcel7818 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "writeToParcel", "(Landroid/os/Parcel;Landroid/net/Uri;)V");
			@__env.CallStaticVoidMethod(android.net.Uri.staticClass, global::android.net.Uri._writeToParcel7818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isHierarchical7819;
		public abstract bool isHierarchical();
		internal static global::MonoJavaBridge.MethodId _isRelative7820;
		public abstract bool isRelative();
		internal static global::MonoJavaBridge.MethodId _getSchemeSpecificPart7821;
		public abstract global::java.lang.String getSchemeSpecificPart();
		internal static global::MonoJavaBridge.MethodId _getEncodedSchemeSpecificPart7822;
		public abstract global::java.lang.String getEncodedSchemeSpecificPart();
		internal static global::MonoJavaBridge.MethodId _getEncodedAuthority7823;
		public abstract global::java.lang.String getEncodedAuthority();
		internal static global::MonoJavaBridge.MethodId _getEncodedUserInfo7824;
		public abstract global::java.lang.String getEncodedUserInfo();
		internal static global::MonoJavaBridge.MethodId _getEncodedPath7825;
		public abstract global::java.lang.String getEncodedPath();
		internal static global::MonoJavaBridge.MethodId _getEncodedQuery7826;
		public abstract global::java.lang.String getEncodedQuery();
		internal static global::MonoJavaBridge.MethodId _getEncodedFragment7827;
		public abstract global::java.lang.String getEncodedFragment();
		internal static global::MonoJavaBridge.MethodId _getPathSegments7828;
		public abstract global::java.util.List getPathSegments();
		internal static global::MonoJavaBridge.MethodId _getLastPathSegment7829;
		public abstract global::java.lang.String getLastPathSegment();
		internal static global::MonoJavaBridge.MethodId _buildUpon7830;
		public abstract global::android.net.Uri.Builder buildUpon();
		internal static global::MonoJavaBridge.MethodId _fromFile7831;
		public static global::android.net.Uri fromFile(java.io.File arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._fromFile7831.native == global::System.IntPtr.Zero)
				global::android.net.Uri._fromFile7831 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "fromFile", "(Ljava/io/File;)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._fromFile7831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _fromParts7832;
		public static global::android.net.Uri fromParts(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._fromParts7832.native == global::System.IntPtr.Zero)
				global::android.net.Uri._fromParts7832 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "fromParts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._fromParts7832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _getQueryParameters7833;
		public virtual global::java.util.List getQueryParameters(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.net.Uri.staticClass, "getQueryParameters", "(Ljava/lang/String;)Ljava/util/List;", ref global::android.net.Uri._getQueryParameters7833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getQueryParameter7834;
		public virtual global::java.lang.String getQueryParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri.staticClass, "getQueryParameter", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.net.Uri._getQueryParameter7834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _withAppendedPath7835;
		public static global::android.net.Uri withAppendedPath(android.net.Uri arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Uri._withAppendedPath7835.native == global::System.IntPtr.Zero)
				global::android.net.Uri._withAppendedPath7835 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "withAppendedPath", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._withAppendedPath7835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY7836;
		public static global::android.net.Uri EMPTY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.net.Uri.staticClass, _EMPTY7836)) as android.net.Uri;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR7837;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.net.Uri.staticClass, _CREATOR7837)) as android.os.Parcelable_Creator;
			}
		}
		static Uri()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Uri.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri"));
			global::android.net.Uri._EMPTY7836 = @__env.GetStaticFieldIDNoThrow(global::android.net.Uri.staticClass, "EMPTY", "Landroid/net/Uri;");
			global::android.net.Uri._CREATOR7837 = @__env.GetStaticFieldIDNoThrow(global::android.net.Uri.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.net.Uri))]
	internal sealed partial class Uri_ : android.net.Uri
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Uri_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7838;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.Uri_.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.net.Uri_._writeToParcel7838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7839;
		public override int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Uri_.staticClass, "describeContents", "()I", ref global::android.net.Uri_._describeContents7839);
		}
		internal static global::MonoJavaBridge.MethodId _toString7840;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.Uri_._toString7840) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath7841;
		public override global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getPath", "()Ljava/lang/String;", ref global::android.net.Uri_._getPath7841) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getScheme7842;
		public override global::java.lang.String getScheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getScheme", "()Ljava/lang/String;", ref global::android.net.Uri_._getScheme7842) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthority7843;
		public override global::java.lang.String getAuthority()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getAuthority", "()Ljava/lang/String;", ref global::android.net.Uri_._getAuthority7843) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFragment7844;
		public override global::java.lang.String getFragment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getFragment", "()Ljava/lang/String;", ref global::android.net.Uri_._getFragment7844) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQuery7845;
		public override global::java.lang.String getQuery()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getQuery", "()Ljava/lang/String;", ref global::android.net.Uri_._getQuery7845) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo7846;
		public override global::java.lang.String getUserInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getUserInfo", "()Ljava/lang/String;", ref global::android.net.Uri_._getUserInfo7846) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPort7847;
		public override int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Uri_.staticClass, "getPort", "()I", ref global::android.net.Uri_._getPort7847);
		}
		internal static global::MonoJavaBridge.MethodId _getHost7848;
		public override global::java.lang.String getHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getHost", "()Ljava/lang/String;", ref global::android.net.Uri_._getHost7848) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isHierarchical7849;
		public override bool isHierarchical()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.Uri_.staticClass, "isHierarchical", "()Z", ref global::android.net.Uri_._isHierarchical7849);
		}
		internal static global::MonoJavaBridge.MethodId _isRelative7850;
		public override bool isRelative()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.Uri_.staticClass, "isRelative", "()Z", ref global::android.net.Uri_._isRelative7850);
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeSpecificPart7851;
		public override global::java.lang.String getSchemeSpecificPart()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;", ref global::android.net.Uri_._getSchemeSpecificPart7851) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedSchemeSpecificPart7852;
		public override global::java.lang.String getEncodedSchemeSpecificPart()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedSchemeSpecificPart", "()Ljava/lang/String;", ref global::android.net.Uri_._getEncodedSchemeSpecificPart7852) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedAuthority7853;
		public override global::java.lang.String getEncodedAuthority()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedAuthority", "()Ljava/lang/String;", ref global::android.net.Uri_._getEncodedAuthority7853) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedUserInfo7854;
		public override global::java.lang.String getEncodedUserInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedUserInfo", "()Ljava/lang/String;", ref global::android.net.Uri_._getEncodedUserInfo7854) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedPath7855;
		public override global::java.lang.String getEncodedPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedPath", "()Ljava/lang/String;", ref global::android.net.Uri_._getEncodedPath7855) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedQuery7856;
		public override global::java.lang.String getEncodedQuery()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedQuery", "()Ljava/lang/String;", ref global::android.net.Uri_._getEncodedQuery7856) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedFragment7857;
		public override global::java.lang.String getEncodedFragment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getEncodedFragment", "()Ljava/lang/String;", ref global::android.net.Uri_._getEncodedFragment7857) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPathSegments7858;
		public override global::java.util.List getPathSegments()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.net.Uri_.staticClass, "getPathSegments", "()Ljava/util/List;", ref global::android.net.Uri_._getPathSegments7858) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getLastPathSegment7859;
		public override global::java.lang.String getLastPathSegment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.Uri_.staticClass, "getLastPathSegment", "()Ljava/lang/String;", ref global::android.net.Uri_._getLastPathSegment7859) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _buildUpon7860;
		public override global::android.net.Uri.Builder buildUpon()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.Uri.Builder>(this, global::android.net.Uri_.staticClass, "buildUpon", "()Landroid/net/Uri$Builder;", ref global::android.net.Uri_._buildUpon7860) as android.net.Uri.Builder;
		}
		static Uri_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Uri_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri"));
		}
		internal static void InitJNI()
		{
		}
	}
}
