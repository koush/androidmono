namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SearchableInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SearchableInfo()
		{
			InitJNI();
		}
		internal SearchableInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _autoUrlDetect764;
		public bool autoUrlDetect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._autoUrlDetect764);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._autoUrlDetect764);
		}
		internal static global::MonoJavaBridge.MethodId _queryAfterZeroResults765;
		public bool queryAfterZeroResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._queryAfterZeroResults765);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._queryAfterZeroResults765);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel766;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchableInfo._writeToParcel766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._writeToParcel766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents767;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._describeContents767);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._describeContents767);
		}
		internal static global::MonoJavaBridge.MethodId _getInputType768;
		public int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getInputType768);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getInputType768);
		}
		internal static global::MonoJavaBridge.MethodId _getImeOptions769;
		public int getImeOptions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getImeOptions769);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getImeOptions769);
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestAuthority770;
		public global::java.lang.String getSuggestAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestAuthority770)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestAuthority770)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestPackage771;
		public global::java.lang.String getSuggestPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestPackage771)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestPackage771)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSearchActivity772;
		public global::android.content.ComponentName getSearchActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSearchActivity772)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSearchActivity772)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _shouldRewriteQueryFromData773;
		public bool shouldRewriteQueryFromData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._shouldRewriteQueryFromData773);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldRewriteQueryFromData773);
		}
		internal static global::MonoJavaBridge.MethodId _shouldRewriteQueryFromText774;
		public bool shouldRewriteQueryFromText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._shouldRewriteQueryFromText774);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldRewriteQueryFromText774);
		}
		internal static global::MonoJavaBridge.MethodId _getSettingsDescriptionId775;
		public int getSettingsDescriptionId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getSettingsDescriptionId775);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSettingsDescriptionId775);
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestPath776;
		public global::java.lang.String getSuggestPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestPath776)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestPath776)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestSelection777;
		public global::java.lang.String getSuggestSelection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestSelection777)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestSelection777)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestIntentAction778;
		public global::java.lang.String getSuggestIntentAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestIntentAction778)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestIntentAction778)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestIntentData779;
		public global::java.lang.String getSuggestIntentData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestIntentData779)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestIntentData779)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestThreshold780;
		public int getSuggestThreshold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestThreshold780);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestThreshold780);
		}
		internal static global::MonoJavaBridge.MethodId _getHintId781;
		public int getHintId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getHintId781);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getHintId781);
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceSearchEnabled782;
		public bool getVoiceSearchEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceSearchEnabled782);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchEnabled782);
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceSearchLaunchWebSearch783;
		public bool getVoiceSearchLaunchWebSearch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch783);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch783);
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceSearchLaunchRecognizer784;
		public bool getVoiceSearchLaunchRecognizer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer784);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer784);
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceLanguageModeId785;
		public int getVoiceLanguageModeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceLanguageModeId785);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceLanguageModeId785);
		}
		internal static global::MonoJavaBridge.MethodId _getVoicePromptTextId786;
		public int getVoicePromptTextId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoicePromptTextId786);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoicePromptTextId786);
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceLanguageId787;
		public int getVoiceLanguageId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceLanguageId787);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceLanguageId787);
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceMaxResults788;
		public int getVoiceMaxResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceMaxResults788);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceMaxResults788);
		}
		internal static global::MonoJavaBridge.MethodId _shouldIncludeInGlobalSearch789;
		public bool shouldIncludeInGlobalSearch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._shouldIncludeInGlobalSearch789);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldIncludeInGlobalSearch789);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR790;
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
			global::android.app.SearchableInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchableInfo"));
			global::android.app.SearchableInfo._autoUrlDetect764 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "autoUrlDetect", "()Z");
			global::android.app.SearchableInfo._queryAfterZeroResults765 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "queryAfterZeroResults", "()Z");
			global::android.app.SearchableInfo._writeToParcel766 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.SearchableInfo._describeContents767 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "describeContents", "()I");
			global::android.app.SearchableInfo._getInputType768 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getInputType", "()I");
			global::android.app.SearchableInfo._getImeOptions769 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getImeOptions", "()I");
			global::android.app.SearchableInfo._getSuggestAuthority770 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestAuthority", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestPackage771 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestPackage", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSearchActivity772 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSearchActivity", "()Landroid/content/ComponentName;");
			global::android.app.SearchableInfo._shouldRewriteQueryFromData773 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromData", "()Z");
			global::android.app.SearchableInfo._shouldRewriteQueryFromText774 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromText", "()Z");
			global::android.app.SearchableInfo._getSettingsDescriptionId775 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSettingsDescriptionId", "()I");
			global::android.app.SearchableInfo._getSuggestPath776 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestPath", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestSelection777 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestSelection", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestIntentAction778 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestIntentAction", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestIntentData779 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestIntentData", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestThreshold780 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestThreshold", "()I");
			global::android.app.SearchableInfo._getHintId781 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getHintId", "()I");
			global::android.app.SearchableInfo._getVoiceSearchEnabled782 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceSearchEnabled", "()Z");
			global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch783 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchWebSearch", "()Z");
			global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer784 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchRecognizer", "()Z");
			global::android.app.SearchableInfo._getVoiceLanguageModeId785 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceLanguageModeId", "()I");
			global::android.app.SearchableInfo._getVoicePromptTextId786 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoicePromptTextId", "()I");
			global::android.app.SearchableInfo._getVoiceLanguageId787 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceLanguageId", "()I");
			global::android.app.SearchableInfo._getVoiceMaxResults788 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceMaxResults", "()I");
			global::android.app.SearchableInfo._shouldIncludeInGlobalSearch789 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "shouldIncludeInGlobalSearch", "()Z");
		}
	}
}
