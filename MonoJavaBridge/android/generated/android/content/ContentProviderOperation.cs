namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentProviderOperation : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentProviderOperation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Builder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Builder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::android.content.ContentProviderOperation build()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderOperation.Builder.staticClass, "build", "()Landroid/content/ContentProviderOperation;", ref global::android.content.ContentProviderOperation.Builder._m0) as android.content.ContentProviderOperation;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual global::android.content.ContentProviderOperation.Builder withValueBackReferences(android.content.ContentValues arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReferences", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;", ref global::android.content.ContentProviderOperation.Builder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ContentProviderOperation.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual global::android.content.ContentProviderOperation.Builder withValueBackReference(java.lang.String arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReference", "(Ljava/lang/String;I)Landroid/content/ContentProviderOperation$Builder;", ref global::android.content.ContentProviderOperation.Builder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.ContentProviderOperation.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual global::android.content.ContentProviderOperation.Builder withSelectionBackReference(int arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderOperation.Builder.staticClass, "withSelectionBackReference", "(II)Landroid/content/ContentProviderOperation$Builder;", ref global::android.content.ContentProviderOperation.Builder._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.ContentProviderOperation.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual global::android.content.ContentProviderOperation.Builder withValues(android.content.ContentValues arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderOperation.Builder.staticClass, "withValues", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;", ref global::android.content.ContentProviderOperation.Builder._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ContentProviderOperation.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual global::android.content.ContentProviderOperation.Builder withValue(java.lang.String arg0, java.lang.Object arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderOperation.Builder.staticClass, "withValue", "(Ljava/lang/String;Ljava/lang/Object;)Landroid/content/ContentProviderOperation$Builder;", ref global::android.content.ContentProviderOperation.Builder._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.ContentProviderOperation.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual global::android.content.ContentProviderOperation.Builder withSelection(java.lang.String arg0, java.lang.String[] arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderOperation.Builder.staticClass, "withSelection", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/ContentProviderOperation$Builder;", ref global::android.content.ContentProviderOperation.Builder._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.ContentProviderOperation.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual global::android.content.ContentProviderOperation.Builder withExpectedCount(int arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderOperation.Builder.staticClass, "withExpectedCount", "(I)Landroid/content/ContentProviderOperation$Builder;", ref global::android.content.ContentProviderOperation.Builder._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ContentProviderOperation.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public virtual global::android.content.ContentProviderOperation.Builder withYieldAllowed(bool arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderOperation.Builder.staticClass, "withYieldAllowed", "(Z)Landroid/content/ContentProviderOperation$Builder;", ref global::android.content.ContentProviderOperation.Builder._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ContentProviderOperation.Builder;
			}
			static Builder()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.ContentProviderOperation.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProviderOperation$Builder"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContentProviderOperation.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.ContentProviderOperation._m0) as java.lang.String;
		}
		public new global::android.net.Uri Uri
		{
			get
			{
				return getUri();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.net.Uri getUri()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderOperation.staticClass, "getUri", "()Landroid/net/Uri;", ref global::android.content.ContentProviderOperation._m1) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProviderOperation.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.ContentProviderOperation._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentProviderOperation.staticClass, "describeContents", "()I", ref global::android.content.ContentProviderOperation._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.content.ContentProviderResult apply(android.content.ContentProvider arg0, android.content.ContentProviderResult[] arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderOperation.staticClass, "apply", "(Landroid/content/ContentProvider;[Landroid/content/ContentProviderResult;I)Landroid/content/ContentProviderResult;", ref global::android.content.ContentProviderOperation._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.content.ContentProviderResult;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.content.ContentProviderOperation.Builder newInsert(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentProviderOperation._m5.native == global::System.IntPtr.Zero)
				global::android.content.ContentProviderOperation._m5 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newInsert", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.content.ContentProviderOperation.Builder newUpdate(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentProviderOperation._m6.native == global::System.IntPtr.Zero)
				global::android.content.ContentProviderOperation._m6 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newUpdate", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.content.ContentProviderOperation.Builder newDelete(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentProviderOperation._m7.native == global::System.IntPtr.Zero)
				global::android.content.ContentProviderOperation._m7 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newDelete", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::android.content.ContentProviderOperation.Builder newAssertQuery(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentProviderOperation._m8.native == global::System.IntPtr.Zero)
				global::android.content.ContentProviderOperation._m8 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newAssertQuery", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isYieldAllowed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContentProviderOperation.staticClass, "isYieldAllowed", "()Z", ref global::android.content.ContentProviderOperation._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isWriteOperation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContentProviderOperation.staticClass, "isWriteOperation", "()Z", ref global::android.content.ContentProviderOperation._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool isReadOperation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContentProviderOperation.staticClass, "isReadOperation", "()Z", ref global::android.content.ContentProviderOperation._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.content.ContentValues resolveValueBackReferences(android.content.ContentProviderResult[] arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ContentValues>(this, global::android.content.ContentProviderOperation.staticClass, "resolveValueBackReferences", "([Landroid/content/ContentProviderResult;I)Landroid/content/ContentValues;", ref global::android.content.ContentProviderOperation._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.ContentValues;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String[] resolveSelectionArgsBackReferences(android.content.ContentProviderResult[] arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.ContentProviderOperation.staticClass, "resolveSelectionArgsBackReferences", "([Landroid/content/ContentProviderResult;I)[Ljava/lang/String;", ref global::android.content.ContentProviderOperation._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1617;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.ContentProviderOperation.staticClass, _CREATOR1617)) as android.os.Parcelable_Creator;
			}
		}
		static ContentProviderOperation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProviderOperation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProviderOperation"));
			global::android.content.ContentProviderOperation._CREATOR1617 = @__env.GetStaticFieldIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
