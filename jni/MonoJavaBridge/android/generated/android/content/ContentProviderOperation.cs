namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ContentProviderOperation : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static ContentProviderOperation()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.ContentProviderOperation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.ContentProviderOperation(@__env);
			}
		}
		protected ContentProviderOperation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Builder : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Builder()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.ContentProviderOperation.Builder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.content.ContentProviderOperation.Builder(@__env);
				}
			}
			protected Builder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _build1013;
			public virtual global::android.content.ContentProviderOperation build() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._build1013));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._build1013));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withValueBackReferences1014;
			public virtual global::android.content.ContentProviderOperation.Builder withValueBackReferences(android.content.ContentValues arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withValueBackReferences1014, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValueBackReferences1014, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withValueBackReference1015;
			public virtual global::android.content.ContentProviderOperation.Builder withValueBackReference(java.lang.String arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withValueBackReference1015, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValueBackReference1015, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withSelectionBackReference1016;
			public virtual global::android.content.ContentProviderOperation.Builder withSelectionBackReference(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withSelectionBackReference1016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withSelectionBackReference1016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withValues1017;
			public virtual global::android.content.ContentProviderOperation.Builder withValues(android.content.ContentValues arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withValues1017, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValues1017, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withValue1018;
			public virtual global::android.content.ContentProviderOperation.Builder withValue(java.lang.String arg0, java.lang.Object arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withValue1018, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValue1018, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withSelection1019;
			public virtual global::android.content.ContentProviderOperation.Builder withSelection(java.lang.String arg0, java.lang.String[] arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withSelection1019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withSelection1019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withExpectedCount1020;
			public virtual global::android.content.ContentProviderOperation.Builder withExpectedCount(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withExpectedCount1020, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withExpectedCount1020, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withYieldAllowed1021;
			public virtual global::android.content.ContentProviderOperation.Builder withYieldAllowed(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withYieldAllowed1021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withYieldAllowed1021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.ContentProviderOperation.Builder.staticClass = @__class;
				global::android.content.ContentProviderOperation.Builder._build1013 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "build", "()Landroid/content/ContentProviderOperation;");
				global::android.content.ContentProviderOperation.Builder._withValueBackReferences1014 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReferences", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValueBackReference1015 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReference", "(Ljava/lang/String;I)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withSelectionBackReference1016 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withSelectionBackReference", "(II)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValues1017 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValues", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValue1018 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValue", "(Ljava/lang/String;Ljava/lang/Object;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withSelection1019 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withSelection", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withExpectedCount1020 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withExpectedCount", "(I)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withYieldAllowed1021 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withYieldAllowed", "(Z)Landroid/content/ContentProviderOperation$Builder;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUri1022;
		public virtual global::android.net.Uri getUri() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation._getUri1022));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._getUri1022));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1023;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentProviderOperation._writeToParcel1023, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._writeToParcel1023, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1024;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContentProviderOperation._describeContents1024);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._describeContents1024);
		}
		internal static global::net.sf.jni4net.jni.MethodId _apply1025;
		public virtual global::android.content.ContentProviderResult apply(android.content.ContentProvider arg0, android.content.ContentProviderResult[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderResult>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation._apply1025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._apply1025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newInsert1026;
		public static global::android.content.ContentProviderOperation.Builder newInsert(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newInsert1026, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newUpdate1027;
		public static global::android.content.ContentProviderOperation.Builder newUpdate(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newUpdate1027, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newDelete1028;
		public static global::android.content.ContentProviderOperation.Builder newDelete(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newDelete1028, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newAssertQuery1029;
		public static global::android.content.ContentProviderOperation.Builder newAssertQuery(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newAssertQuery1029, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isYieldAllowed1030;
		public virtual bool isYieldAllowed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContentProviderOperation._isYieldAllowed1030);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isYieldAllowed1030);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isWriteOperation1031;
		public virtual bool isWriteOperation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContentProviderOperation._isWriteOperation1031);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isWriteOperation1031);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isReadOperation1032;
		public virtual bool isReadOperation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContentProviderOperation._isReadOperation1032);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isReadOperation1032);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resolveValueBackReferences1033;
		public virtual global::android.content.ContentValues resolveValueBackReferences(android.content.ContentProviderResult[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentValues>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation._resolveValueBackReferences1033, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentValues>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._resolveValueBackReferences1033, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _resolveSelectionArgsBackReferences1034;
		public virtual global::java.lang.String[] resolveSelectionArgsBackReferences(android.content.ContentProviderResult[] arg0, int arg1) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences1034, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences1034, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1035;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.ContentProviderOperation.staticClass = @__class;
			global::android.content.ContentProviderOperation._getUri1022 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "getUri", "()Landroid/net/Uri;");
			global::android.content.ContentProviderOperation._writeToParcel1023 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ContentProviderOperation._describeContents1024 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "describeContents", "()I");
			global::android.content.ContentProviderOperation._apply1025 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "apply", "(Landroid/content/ContentProvider;[Landroid/content/ContentProviderResult;I)Landroid/content/ContentProviderResult;");
			global::android.content.ContentProviderOperation._newInsert1026 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newInsert", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newUpdate1027 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newUpdate", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newDelete1028 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newDelete", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newAssertQuery1029 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newAssertQuery", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._isYieldAllowed1030 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "isYieldAllowed", "()Z");
			global::android.content.ContentProviderOperation._isWriteOperation1031 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "isWriteOperation", "()Z");
			global::android.content.ContentProviderOperation._isReadOperation1032 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "isReadOperation", "()Z");
			global::android.content.ContentProviderOperation._resolveValueBackReferences1033 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "resolveValueBackReferences", "([Landroid/content/ContentProviderResult;I)Landroid/content/ContentValues;");
			global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences1034 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "resolveSelectionArgsBackReferences", "([Landroid/content/ContentProviderResult;I)[Ljava/lang/String;");
		}
	}
}
