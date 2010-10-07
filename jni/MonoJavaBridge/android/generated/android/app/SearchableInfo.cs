namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class SearchableInfo : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static SearchableInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.SearchableInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.SearchableInfo(@__env);
			}
		}
		internal SearchableInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _autoUrlDetect754;
		public bool autoUrlDetect() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.SearchableInfo._autoUrlDetect754);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._autoUrlDetect754);
		}
		internal static global::net.sf.jni4net.jni.MethodId _queryAfterZeroResults755;
		public bool queryAfterZeroResults() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.SearchableInfo._queryAfterZeroResults755);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._queryAfterZeroResults755);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel756;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchableInfo._writeToParcel756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._writeToParcel756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents757;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.SearchableInfo._describeContents757);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._describeContents757);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputType758;
		public int getInputType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.SearchableInfo._getInputType758);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getInputType758);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getImeOptions759;
		public int getImeOptions() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.SearchableInfo._getImeOptions759);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getImeOptions759);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestAuthority760;
		public global::java.lang.String getSuggestAuthority() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.SearchableInfo._getSuggestAuthority760));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestAuthority760));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestPackage761;
		public global::java.lang.String getSuggestPackage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.SearchableInfo._getSuggestPackage761));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestPackage761));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSearchActivity762;
		public global::android.content.ComponentName getSearchActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.SearchableInfo._getSearchActivity762));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSearchActivity762));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldRewriteQueryFromData763;
		public bool shouldRewriteQueryFromData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.SearchableInfo._shouldRewriteQueryFromData763);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldRewriteQueryFromData763);
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldRewriteQueryFromText764;
		public bool shouldRewriteQueryFromText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.SearchableInfo._shouldRewriteQueryFromText764);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldRewriteQueryFromText764);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSettingsDescriptionId765;
		public int getSettingsDescriptionId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.SearchableInfo._getSettingsDescriptionId765);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSettingsDescriptionId765);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestPath766;
		public global::java.lang.String getSuggestPath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.SearchableInfo._getSuggestPath766));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestPath766));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestSelection767;
		public global::java.lang.String getSuggestSelection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.SearchableInfo._getSuggestSelection767));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestSelection767));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestIntentAction768;
		public global::java.lang.String getSuggestIntentAction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.SearchableInfo._getSuggestIntentAction768));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestIntentAction768));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestIntentData769;
		public global::java.lang.String getSuggestIntentData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.SearchableInfo._getSuggestIntentData769));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestIntentData769));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestThreshold770;
		public int getSuggestThreshold() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.SearchableInfo._getSuggestThreshold770);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestThreshold770);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHintId771;
		public int getHintId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.SearchableInfo._getHintId771);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getHintId771);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceSearchEnabled772;
		public bool getVoiceSearchEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.SearchableInfo._getVoiceSearchEnabled772);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchEnabled772);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceSearchLaunchWebSearch773;
		public bool getVoiceSearchLaunchWebSearch() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch773);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch773);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceSearchLaunchRecognizer774;
		public bool getVoiceSearchLaunchRecognizer() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer774);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer774);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceLanguageModeId775;
		public int getVoiceLanguageModeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.SearchableInfo._getVoiceLanguageModeId775);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceLanguageModeId775);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVoicePromptTextId776;
		public int getVoicePromptTextId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.SearchableInfo._getVoicePromptTextId776);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoicePromptTextId776);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceLanguageId777;
		public int getVoiceLanguageId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.SearchableInfo._getVoiceLanguageId777);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceLanguageId777);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceMaxResults778;
		public int getVoiceMaxResults() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.SearchableInfo._getVoiceMaxResults778);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceMaxResults778);
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldIncludeInGlobalSearch779;
		public bool shouldIncludeInGlobalSearch() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.SearchableInfo._shouldIncludeInGlobalSearch779);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldIncludeInGlobalSearch779);
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR780;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.SearchableInfo.staticClass = @__class;
			global::android.app.SearchableInfo._autoUrlDetect754 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "autoUrlDetect", "()Z");
			global::android.app.SearchableInfo._queryAfterZeroResults755 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "queryAfterZeroResults", "()Z");
			global::android.app.SearchableInfo._writeToParcel756 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.SearchableInfo._describeContents757 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "describeContents", "()I");
			global::android.app.SearchableInfo._getInputType758 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getInputType", "()I");
			global::android.app.SearchableInfo._getImeOptions759 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getImeOptions", "()I");
			global::android.app.SearchableInfo._getSuggestAuthority760 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getSuggestAuthority", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestPackage761 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getSuggestPackage", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSearchActivity762 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getSearchActivity", "()Landroid/content/ComponentName;");
			global::android.app.SearchableInfo._shouldRewriteQueryFromData763 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromData", "()Z");
			global::android.app.SearchableInfo._shouldRewriteQueryFromText764 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromText", "()Z");
			global::android.app.SearchableInfo._getSettingsDescriptionId765 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getSettingsDescriptionId", "()I");
			global::android.app.SearchableInfo._getSuggestPath766 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getSuggestPath", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestSelection767 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getSuggestSelection", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestIntentAction768 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getSuggestIntentAction", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestIntentData769 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getSuggestIntentData", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestThreshold770 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getSuggestThreshold", "()I");
			global::android.app.SearchableInfo._getHintId771 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getHintId", "()I");
			global::android.app.SearchableInfo._getVoiceSearchEnabled772 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getVoiceSearchEnabled", "()Z");
			global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch773 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchWebSearch", "()Z");
			global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer774 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchRecognizer", "()Z");
			global::android.app.SearchableInfo._getVoiceLanguageModeId775 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getVoiceLanguageModeId", "()I");
			global::android.app.SearchableInfo._getVoicePromptTextId776 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getVoicePromptTextId", "()I");
			global::android.app.SearchableInfo._getVoiceLanguageId777 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getVoiceLanguageId", "()I");
			global::android.app.SearchableInfo._getVoiceMaxResults778 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "getVoiceMaxResults", "()I");
			global::android.app.SearchableInfo._shouldIncludeInGlobalSearch779 = @__env.GetMethodID(global::android.app.SearchableInfo.staticClass, "shouldIncludeInGlobalSearch", "()Z");
		}
	}
}
