namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentProviderOperation : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentProviderOperation()
		{
			InitJNI();
		}
		protected ContentProviderOperation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Builder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Builder()
			{
				InitJNI();
			}
			protected Builder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _build1168;
			public virtual global::android.content.ContentProviderOperation build() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._build1168)) as android.content.ContentProviderOperation;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._build1168)) as android.content.ContentProviderOperation;
			}
			internal static global::MonoJavaBridge.MethodId _withValueBackReferences1169;
			public virtual global::android.content.ContentProviderOperation.Builder withValueBackReferences(android.content.ContentValues arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withValueBackReferences1169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValueBackReferences1169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withValueBackReference1170;
			public virtual global::android.content.ContentProviderOperation.Builder withValueBackReference(java.lang.String arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withValueBackReference1170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValueBackReference1170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withSelectionBackReference1171;
			public virtual global::android.content.ContentProviderOperation.Builder withSelectionBackReference(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withSelectionBackReference1171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withSelectionBackReference1171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withValues1172;
			public virtual global::android.content.ContentProviderOperation.Builder withValues(android.content.ContentValues arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withValues1172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValues1172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withValue1173;
			public virtual global::android.content.ContentProviderOperation.Builder withValue(java.lang.String arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withValue1173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValue1173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withSelection1174;
			public virtual global::android.content.ContentProviderOperation.Builder withSelection(java.lang.String arg0, java.lang.String[] arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withSelection1174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withSelection1174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withExpectedCount1175;
			public virtual global::android.content.ContentProviderOperation.Builder withExpectedCount(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withExpectedCount1175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withExpectedCount1175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withYieldAllowed1176;
			public virtual global::android.content.ContentProviderOperation.Builder withYieldAllowed(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withYieldAllowed1176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withYieldAllowed1176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.ContentProviderOperation.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProviderOperation$Builder"));
				global::android.content.ContentProviderOperation.Builder._build1168 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "build", "()Landroid/content/ContentProviderOperation;");
				global::android.content.ContentProviderOperation.Builder._withValueBackReferences1169 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReferences", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValueBackReference1170 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReference", "(Ljava/lang/String;I)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withSelectionBackReference1171 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withSelectionBackReference", "(II)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValues1172 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withValues", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValue1173 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withValue", "(Ljava/lang/String;Ljava/lang/Object;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withSelection1174 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withSelection", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withExpectedCount1175 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withExpectedCount", "(I)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withYieldAllowed1176 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withYieldAllowed", "(Z)Landroid/content/ContentProviderOperation$Builder;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString1177;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation._toString1177)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._toString1177)) as java.lang.String;
		}
		public new global::android.net.Uri Uri
		{
			get
			{
				return getUri();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUri1178;
		public virtual global::android.net.Uri getUri() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation._getUri1178)) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._getUri1178)) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1179;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentProviderOperation._writeToParcel1179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._writeToParcel1179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1180;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProviderOperation._describeContents1180);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._describeContents1180);
		}
		internal static global::MonoJavaBridge.MethodId _apply1181;
		public virtual global::android.content.ContentProviderResult apply(android.content.ContentProvider arg0, android.content.ContentProviderResult[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation._apply1181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.ContentProviderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._apply1181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.ContentProviderResult;
		}
		internal static global::MonoJavaBridge.MethodId _newInsert1182;
		public static global::android.content.ContentProviderOperation.Builder newInsert(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newInsert1182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		internal static global::MonoJavaBridge.MethodId _newUpdate1183;
		public static global::android.content.ContentProviderOperation.Builder newUpdate(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newUpdate1183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		internal static global::MonoJavaBridge.MethodId _newDelete1184;
		public static global::android.content.ContentProviderOperation.Builder newDelete(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newDelete1184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		internal static global::MonoJavaBridge.MethodId _newAssertQuery1185;
		public static global::android.content.ContentProviderOperation.Builder newAssertQuery(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newAssertQuery1185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		internal static global::MonoJavaBridge.MethodId _isYieldAllowed1186;
		public virtual bool isYieldAllowed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation._isYieldAllowed1186);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isYieldAllowed1186);
		}
		internal static global::MonoJavaBridge.MethodId _isWriteOperation1187;
		public virtual bool isWriteOperation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation._isWriteOperation1187);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isWriteOperation1187);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOperation1188;
		public virtual bool isReadOperation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation._isReadOperation1188);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isReadOperation1188);
		}
		internal static global::MonoJavaBridge.MethodId _resolveValueBackReferences1189;
		public virtual global::android.content.ContentValues resolveValueBackReferences(android.content.ContentProviderResult[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation._resolveValueBackReferences1189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentValues;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._resolveValueBackReferences1189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentValues;
		}
		internal static global::MonoJavaBridge.MethodId _resolveSelectionArgsBackReferences1190;
		public virtual global::java.lang.String[] resolveSelectionArgsBackReferences(android.content.ContentProviderResult[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences1190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences1190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1191;
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
			global::android.content.ContentProviderOperation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProviderOperation"));
			global::android.content.ContentProviderOperation._toString1177 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.ContentProviderOperation._getUri1178 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "getUri", "()Landroid/net/Uri;");
			global::android.content.ContentProviderOperation._writeToParcel1179 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ContentProviderOperation._describeContents1180 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "describeContents", "()I");
			global::android.content.ContentProviderOperation._apply1181 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "apply", "(Landroid/content/ContentProvider;[Landroid/content/ContentProviderResult;I)Landroid/content/ContentProviderResult;");
			global::android.content.ContentProviderOperation._newInsert1182 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newInsert", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newUpdate1183 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newUpdate", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newDelete1184 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newDelete", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newAssertQuery1185 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newAssertQuery", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._isYieldAllowed1186 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "isYieldAllowed", "()Z");
			global::android.content.ContentProviderOperation._isWriteOperation1187 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "isWriteOperation", "()Z");
			global::android.content.ContentProviderOperation._isReadOperation1188 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "isReadOperation", "()Z");
			global::android.content.ContentProviderOperation._resolveValueBackReferences1189 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "resolveValueBackReferences", "([Landroid/content/ContentProviderResult;I)Landroid/content/ContentValues;");
			global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences1190 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "resolveSelectionArgsBackReferences", "([Landroid/content/ContentProviderResult;I)[Ljava/lang/String;");
		}
	}
}
