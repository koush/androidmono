namespace android.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.net.Uri_))]
	public abstract partial class Uri : java.lang.Object, android.os.Parcelable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Uri()
		{
			InitJNI();
		}
		protected Uri(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Builder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Builder()
			{
				InitJNI();
			}
			internal Builder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString5266;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._toString5266)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._toString5266)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _path5267;
			public global::android.net.Uri.Builder path(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._path5267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._path5267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _query5268;
			public global::android.net.Uri.Builder query(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._query5268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._query5268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _authority5269;
			public global::android.net.Uri.Builder authority(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._authority5269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._authority5269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _scheme5270;
			public global::android.net.Uri.Builder scheme(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._scheme5270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._scheme5270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _fragment5271;
			public global::android.net.Uri.Builder fragment(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._fragment5271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._fragment5271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _build5272;
			public global::android.net.Uri build() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._build5272)) as android.net.Uri;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._build5272)) as android.net.Uri;
			}
			internal static global::MonoJavaBridge.MethodId _opaquePart5273;
			public global::android.net.Uri.Builder opaquePart(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._opaquePart5273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._opaquePart5273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedOpaquePart5274;
			public global::android.net.Uri.Builder encodedOpaquePart(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._encodedOpaquePart5274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedOpaquePart5274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedAuthority5275;
			public global::android.net.Uri.Builder encodedAuthority(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._encodedAuthority5275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedAuthority5275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedPath5276;
			public global::android.net.Uri.Builder encodedPath(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._encodedPath5276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedPath5276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _appendPath5277;
			public global::android.net.Uri.Builder appendPath(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._appendPath5277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._appendPath5277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _appendEncodedPath5278;
			public global::android.net.Uri.Builder appendEncodedPath(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._appendEncodedPath5278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._appendEncodedPath5278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedQuery5279;
			public global::android.net.Uri.Builder encodedQuery(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._encodedQuery5279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedQuery5279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedFragment5280;
			public global::android.net.Uri.Builder encodedFragment(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._encodedFragment5280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedFragment5280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _appendQueryParameter5281;
			public global::android.net.Uri.Builder appendQueryParameter(java.lang.String arg0, java.lang.String arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._appendQueryParameter5281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._appendQueryParameter5281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _Builder5282;
			public Builder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._Builder5282);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.Uri.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri$Builder"));
				global::android.net.Uri.Builder._toString5266 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "toString", "()Ljava/lang/String;");
				global::android.net.Uri.Builder._path5267 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "path", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._query5268 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "query", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._authority5269 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "authority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._scheme5270 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "scheme", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._fragment5271 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "fragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._build5272 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "build", "()Landroid/net/Uri;");
				global::android.net.Uri.Builder._opaquePart5273 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "opaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._encodedOpaquePart5274 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "encodedOpaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._encodedAuthority5275 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "encodedAuthority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._encodedPath5276 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "encodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._appendPath5277 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "appendPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._appendEncodedPath5278 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "appendEncodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._encodedQuery5279 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "encodedQuery", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._encodedFragment5280 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "encodedFragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._appendQueryParameter5281 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "appendQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._Builder5282 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5283;
		public abstract void writeToParcel(android.os.Parcel arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _describeContents5284;
		public abstract int describeContents();
		internal static global::MonoJavaBridge.MethodId _equals5285;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.Uri._equals5285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._equals5285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString5286;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode5287;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Uri._hashCode5287);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._hashCode5287);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo5288;
		public virtual int compareTo(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Uri._compareTo5288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._compareTo5288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo5289;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Uri._compareTo5289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._compareTo5289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decode5290;
		public static global::java.lang.String decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._decode5290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _encode5291;
		public static global::java.lang.String encode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._encode5291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _encode5292;
		public static global::java.lang.String encode(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._encode5292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAbsolute5293;
		public virtual bool isAbsolute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.Uri._isAbsolute5293);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._isAbsolute5293);
		}
		internal static global::MonoJavaBridge.MethodId _getPath5294;
		public abstract global::java.lang.String getPath();
		internal static global::MonoJavaBridge.MethodId _isOpaque5295;
		public virtual bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.Uri._isOpaque5295);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._isOpaque5295);
		}
		internal static global::MonoJavaBridge.MethodId _getScheme5296;
		public abstract global::java.lang.String getScheme();
		internal static global::MonoJavaBridge.MethodId _getAuthority5297;
		public abstract global::java.lang.String getAuthority();
		internal static global::MonoJavaBridge.MethodId _getFragment5298;
		public abstract global::java.lang.String getFragment();
		internal static global::MonoJavaBridge.MethodId _getQuery5299;
		public abstract global::java.lang.String getQuery();
		internal static global::MonoJavaBridge.MethodId _parse5300;
		public static global::android.net.Uri parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._parse5300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo5301;
		public abstract global::java.lang.String getUserInfo();
		internal static global::MonoJavaBridge.MethodId _getPort5302;
		public abstract int getPort();
		internal static global::MonoJavaBridge.MethodId _getHost5303;
		public abstract global::java.lang.String getHost();
		internal static global::MonoJavaBridge.MethodId _writeToParcel5304;
		public static void writeToParcel(android.os.Parcel arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.net.Uri.staticClass, global::android.net.Uri._writeToParcel5304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isHierarchical5305;
		public abstract bool isHierarchical();
		internal static global::MonoJavaBridge.MethodId _isRelative5306;
		public abstract bool isRelative();
		internal static global::MonoJavaBridge.MethodId _getSchemeSpecificPart5307;
		public abstract global::java.lang.String getSchemeSpecificPart();
		internal static global::MonoJavaBridge.MethodId _getEncodedSchemeSpecificPart5308;
		public abstract global::java.lang.String getEncodedSchemeSpecificPart();
		internal static global::MonoJavaBridge.MethodId _getEncodedAuthority5309;
		public abstract global::java.lang.String getEncodedAuthority();
		internal static global::MonoJavaBridge.MethodId _getEncodedUserInfo5310;
		public abstract global::java.lang.String getEncodedUserInfo();
		internal static global::MonoJavaBridge.MethodId _getEncodedPath5311;
		public abstract global::java.lang.String getEncodedPath();
		internal static global::MonoJavaBridge.MethodId _getEncodedQuery5312;
		public abstract global::java.lang.String getEncodedQuery();
		internal static global::MonoJavaBridge.MethodId _getEncodedFragment5313;
		public abstract global::java.lang.String getEncodedFragment();
		internal static global::MonoJavaBridge.MethodId _getPathSegments5314;
		public abstract global::java.util.List getPathSegments();
		internal static global::MonoJavaBridge.MethodId _getLastPathSegment5315;
		public abstract global::java.lang.String getLastPathSegment();
		internal static global::MonoJavaBridge.MethodId _buildUpon5316;
		public abstract global::android.net.Uri.Builder buildUpon();
		internal static global::MonoJavaBridge.MethodId _fromFile5317;
		public static global::android.net.Uri fromFile(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._fromFile5317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _fromParts5318;
		public static global::android.net.Uri fromParts(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._fromParts5318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _getQueryParameters5319;
		public virtual global::java.util.List getQueryParameters(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri._getQueryParameters5319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._getQueryParameters5319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getQueryParameter5320;
		public virtual global::java.lang.String getQueryParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri._getQueryParameter5320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._getQueryParameter5320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _withAppendedPath5321;
		public static global::android.net.Uri withAppendedPath(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._withAppendedPath5321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY5322;
		public static global::android.net.Uri EMPTY
		{
			get
			{
				return default(global::android.net.Uri);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5323;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Uri.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri"));
			global::android.net.Uri._writeToParcel5283 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.Uri._describeContents5284 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "describeContents", "()I");
			global::android.net.Uri._equals5285 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.net.Uri._toString5286 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.Uri._hashCode5287 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "hashCode", "()I");
			global::android.net.Uri._compareTo5288 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "compareTo", "(Landroid/net/Uri;)I");
			global::android.net.Uri._compareTo5289 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.net.Uri._decode5290 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.Uri._encode5291 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.Uri._encode5292 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.Uri._isAbsolute5293 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "isAbsolute", "()Z");
			global::android.net.Uri._getPath5294 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.net.Uri._isOpaque5295 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "isOpaque", "()Z");
			global::android.net.Uri._getScheme5296 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getScheme", "()Ljava/lang/String;");
			global::android.net.Uri._getAuthority5297 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getAuthority", "()Ljava/lang/String;");
			global::android.net.Uri._getFragment5298 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getFragment", "()Ljava/lang/String;");
			global::android.net.Uri._getQuery5299 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getQuery", "()Ljava/lang/String;");
			global::android.net.Uri._parse5300 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "parse", "(Ljava/lang/String;)Landroid/net/Uri;");
			global::android.net.Uri._getUserInfo5301 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getUserInfo", "()Ljava/lang/String;");
			global::android.net.Uri._getPort5302 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getPort", "()I");
			global::android.net.Uri._getHost5303 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getHost", "()Ljava/lang/String;");
			global::android.net.Uri._writeToParcel5304 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "writeToParcel", "(Landroid/os/Parcel;Landroid/net/Uri;)V");
			global::android.net.Uri._isHierarchical5305 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "isHierarchical", "()Z");
			global::android.net.Uri._isRelative5306 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "isRelative", "()Z");
			global::android.net.Uri._getSchemeSpecificPart5307 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedSchemeSpecificPart5308 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedSchemeSpecificPart", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedAuthority5309 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedAuthority", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedUserInfo5310 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedUserInfo", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedPath5311 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedPath", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedQuery5312 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedQuery", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedFragment5313 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedFragment", "()Ljava/lang/String;");
			global::android.net.Uri._getPathSegments5314 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getPathSegments", "()Ljava/util/List;");
			global::android.net.Uri._getLastPathSegment5315 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getLastPathSegment", "()Ljava/lang/String;");
			global::android.net.Uri._buildUpon5316 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "buildUpon", "()Landroid/net/Uri$Builder;");
			global::android.net.Uri._fromFile5317 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "fromFile", "(Ljava/io/File;)Landroid/net/Uri;");
			global::android.net.Uri._fromParts5318 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "fromParts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;");
			global::android.net.Uri._getQueryParameters5319 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getQueryParameters", "(Ljava/lang/String;)Ljava/util/List;");
			global::android.net.Uri._getQueryParameter5320 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getQueryParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.Uri._withAppendedPath5321 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "withAppendedPath", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.net.Uri))]
	public sealed partial class Uri_ : android.net.Uri
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Uri_()
		{
			InitJNI();
		}
		internal Uri_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5324;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.Uri_._writeToParcel5324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._writeToParcel5324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5325;
		public override int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Uri_._describeContents5325);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._describeContents5325);
		}
		internal static global::MonoJavaBridge.MethodId _toString5326;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._toString5326)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._toString5326)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath5327;
		public override global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getPath5327)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getPath5327)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getScheme5328;
		public override global::java.lang.String getScheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getScheme5328)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getScheme5328)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthority5329;
		public override global::java.lang.String getAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getAuthority5329)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getAuthority5329)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFragment5330;
		public override global::java.lang.String getFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getFragment5330)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getFragment5330)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQuery5331;
		public override global::java.lang.String getQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getQuery5331)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getQuery5331)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo5332;
		public override global::java.lang.String getUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getUserInfo5332)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getUserInfo5332)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPort5333;
		public override int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Uri_._getPort5333);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getPort5333);
		}
		internal static global::MonoJavaBridge.MethodId _getHost5334;
		public override global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getHost5334)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getHost5334)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isHierarchical5335;
		public override bool isHierarchical() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.Uri_._isHierarchical5335);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._isHierarchical5335);
		}
		internal static global::MonoJavaBridge.MethodId _isRelative5336;
		public override bool isRelative() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.Uri_._isRelative5336);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._isRelative5336);
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeSpecificPart5337;
		public override global::java.lang.String getSchemeSpecificPart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getSchemeSpecificPart5337)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getSchemeSpecificPart5337)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedSchemeSpecificPart5338;
		public override global::java.lang.String getEncodedSchemeSpecificPart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedSchemeSpecificPart5338)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedSchemeSpecificPart5338)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedAuthority5339;
		public override global::java.lang.String getEncodedAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedAuthority5339)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedAuthority5339)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedUserInfo5340;
		public override global::java.lang.String getEncodedUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedUserInfo5340)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedUserInfo5340)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedPath5341;
		public override global::java.lang.String getEncodedPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedPath5341)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedPath5341)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedQuery5342;
		public override global::java.lang.String getEncodedQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedQuery5342)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedQuery5342)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedFragment5343;
		public override global::java.lang.String getEncodedFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedFragment5343)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedFragment5343)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPathSegments5344;
		public override global::java.util.List getPathSegments() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getPathSegments5344)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getPathSegments5344)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getLastPathSegment5345;
		public override global::java.lang.String getLastPathSegment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getLastPathSegment5345)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getLastPathSegment5345)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _buildUpon5346;
		public override global::android.net.Uri.Builder buildUpon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._buildUpon5346)) as android.net.Uri.Builder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._buildUpon5346)) as android.net.Uri.Builder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Uri_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri"));
			global::android.net.Uri_._writeToParcel5324 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.Uri_._describeContents5325 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "describeContents", "()I");
			global::android.net.Uri_._toString5326 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.Uri_._getPath5327 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.net.Uri_._getScheme5328 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getScheme", "()Ljava/lang/String;");
			global::android.net.Uri_._getAuthority5329 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getAuthority", "()Ljava/lang/String;");
			global::android.net.Uri_._getFragment5330 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getFragment", "()Ljava/lang/String;");
			global::android.net.Uri_._getQuery5331 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getQuery", "()Ljava/lang/String;");
			global::android.net.Uri_._getUserInfo5332 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getUserInfo", "()Ljava/lang/String;");
			global::android.net.Uri_._getPort5333 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getPort", "()I");
			global::android.net.Uri_._getHost5334 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getHost", "()Ljava/lang/String;");
			global::android.net.Uri_._isHierarchical5335 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "isHierarchical", "()Z");
			global::android.net.Uri_._isRelative5336 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "isRelative", "()Z");
			global::android.net.Uri_._getSchemeSpecificPart5337 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedSchemeSpecificPart5338 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedSchemeSpecificPart", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedAuthority5339 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedAuthority", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedUserInfo5340 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedUserInfo", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedPath5341 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedPath", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedQuery5342 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedQuery", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedFragment5343 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedFragment", "()Ljava/lang/String;");
			global::android.net.Uri_._getPathSegments5344 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getPathSegments", "()Ljava/util/List;");
			global::android.net.Uri_._getLastPathSegment5345 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getLastPathSegment", "()Ljava/lang/String;");
			global::android.net.Uri_._buildUpon5346 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "buildUpon", "()Landroid/net/Uri$Builder;");
		}
	}
}
