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
			internal static global::net.sf.jni4net.jni.MethodId _build1145;
			public virtual global::android.content.ContentProviderOperation build() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._build1145));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._build1145));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withValueBackReferences1146;
			public virtual global::android.content.ContentProviderOperation.Builder withValueBackReferences(android.content.ContentValues arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withValueBackReferences1146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValueBackReferences1146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withValueBackReference1147;
			public virtual global::android.content.ContentProviderOperation.Builder withValueBackReference(java.lang.String arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withValueBackReference1147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValueBackReference1147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withSelectionBackReference1148;
			public virtual global::android.content.ContentProviderOperation.Builder withSelectionBackReference(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withSelectionBackReference1148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withSelectionBackReference1148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withValues1149;
			public virtual global::android.content.ContentProviderOperation.Builder withValues(android.content.ContentValues arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withValues1149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValues1149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withValue1150;
			public virtual global::android.content.ContentProviderOperation.Builder withValue(java.lang.String arg0, java.lang.Object arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withValue1150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValue1150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withSelection1151;
			public virtual global::android.content.ContentProviderOperation.Builder withSelection(java.lang.String arg0, java.lang.String[] arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withSelection1151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withSelection1151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withExpectedCount1152;
			public virtual global::android.content.ContentProviderOperation.Builder withExpectedCount(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withExpectedCount1152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withExpectedCount1152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _withYieldAllowed1153;
			public virtual global::android.content.ContentProviderOperation.Builder withYieldAllowed(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder._withYieldAllowed1153, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withYieldAllowed1153, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.ContentProviderOperation.Builder.staticClass = @__class;
				global::android.content.ContentProviderOperation.Builder._build1145 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "build", "()Landroid/content/ContentProviderOperation;");
				global::android.content.ContentProviderOperation.Builder._withValueBackReferences1146 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReferences", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValueBackReference1147 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReference", "(Ljava/lang/String;I)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withSelectionBackReference1148 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withSelectionBackReference", "(II)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValues1149 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValues", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValue1150 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValue", "(Ljava/lang/String;Ljava/lang/Object;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withSelection1151 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withSelection", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withExpectedCount1152 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withExpectedCount", "(I)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withYieldAllowed1153 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withYieldAllowed", "(Z)Landroid/content/ContentProviderOperation$Builder;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1154;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation._toString1154));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._toString1154));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUri1155;
		public virtual global::android.net.Uri getUri() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation._getUri1155));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._getUri1155));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1156;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentProviderOperation._writeToParcel1156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._writeToParcel1156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1157;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContentProviderOperation._describeContents1157);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._describeContents1157);
		}
		internal static global::net.sf.jni4net.jni.MethodId _apply1158;
		public virtual global::android.content.ContentProviderResult apply(android.content.ContentProvider arg0, android.content.ContentProviderResult[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderResult>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation._apply1158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._apply1158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newInsert1159;
		public static global::android.content.ContentProviderOperation.Builder newInsert(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newInsert1159, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newUpdate1160;
		public static global::android.content.ContentProviderOperation.Builder newUpdate(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newUpdate1160, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newDelete1161;
		public static global::android.content.ContentProviderOperation.Builder newDelete(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newDelete1161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newAssertQuery1162;
		public static global::android.content.ContentProviderOperation.Builder newAssertQuery(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newAssertQuery1162, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isYieldAllowed1163;
		public virtual bool isYieldAllowed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContentProviderOperation._isYieldAllowed1163);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isYieldAllowed1163);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isWriteOperation1164;
		public virtual bool isWriteOperation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContentProviderOperation._isWriteOperation1164);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isWriteOperation1164);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isReadOperation1165;
		public virtual bool isReadOperation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContentProviderOperation._isReadOperation1165);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isReadOperation1165);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resolveValueBackReferences1166;
		public virtual global::android.content.ContentValues resolveValueBackReferences(android.content.ContentProviderResult[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentValues>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation._resolveValueBackReferences1166, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentValues>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._resolveValueBackReferences1166, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _resolveSelectionArgsBackReferences1167;
		public virtual global::java.lang.String[] resolveSelectionArgsBackReferences(android.content.ContentProviderResult[] arg0, int arg1) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences1167, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences1167, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1168;
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
			global::android.content.ContentProviderOperation._toString1154 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.ContentProviderOperation._getUri1155 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "getUri", "()Landroid/net/Uri;");
			global::android.content.ContentProviderOperation._writeToParcel1156 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ContentProviderOperation._describeContents1157 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "describeContents", "()I");
			global::android.content.ContentProviderOperation._apply1158 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "apply", "(Landroid/content/ContentProvider;[Landroid/content/ContentProviderResult;I)Landroid/content/ContentProviderResult;");
			global::android.content.ContentProviderOperation._newInsert1159 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newInsert", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newUpdate1160 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newUpdate", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newDelete1161 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newDelete", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newAssertQuery1162 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newAssertQuery", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._isYieldAllowed1163 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "isYieldAllowed", "()Z");
			global::android.content.ContentProviderOperation._isWriteOperation1164 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "isWriteOperation", "()Z");
			global::android.content.ContentProviderOperation._isReadOperation1165 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "isReadOperation", "()Z");
			global::android.content.ContentProviderOperation._resolveValueBackReferences1166 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "resolveValueBackReferences", "([Landroid/content/ContentProviderResult;I)Landroid/content/ContentValues;");
			global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences1167 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "resolveSelectionArgsBackReferences", "([Landroid/content/ContentProviderResult;I)[Ljava/lang/String;");
		}
	}
}
