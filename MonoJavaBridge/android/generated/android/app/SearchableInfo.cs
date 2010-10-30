namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SearchableInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SearchableInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _autoUrlDetect2109;
		public bool autoUrlDetect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "autoUrlDetect", "()Z", ref global::android.app.SearchableInfo._autoUrlDetect2109);
		}
		internal static global::MonoJavaBridge.MethodId _queryAfterZeroResults2110;
		public bool queryAfterZeroResults()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "queryAfterZeroResults", "()Z", ref global::android.app.SearchableInfo._queryAfterZeroResults2110);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2111;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.SearchableInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.SearchableInfo._writeToParcel2111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2112;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "describeContents", "()I", ref global::android.app.SearchableInfo._describeContents2112);
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType2113;
		public int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getInputType", "()I", ref global::android.app.SearchableInfo._getInputType2113);
		}
		public new int ImeOptions
		{
			get
			{
				return getImeOptions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImeOptions2114;
		public int getImeOptions()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getImeOptions", "()I", ref global::android.app.SearchableInfo._getImeOptions2114);
		}
		public new global::java.lang.String SuggestAuthority
		{
			get
			{
				return getSuggestAuthority();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestAuthority2115;
		public global::java.lang.String getSuggestAuthority()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestAuthority", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._getSuggestAuthority2115) as java.lang.String;
		}
		public new global::java.lang.String SuggestPackage
		{
			get
			{
				return getSuggestPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestPackage2116;
		public global::java.lang.String getSuggestPackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestPackage", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._getSuggestPackage2116) as java.lang.String;
		}
		public new global::android.content.ComponentName SearchActivity
		{
			get
			{
				return getSearchActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSearchActivity2117;
		public global::android.content.ComponentName getSearchActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.app.SearchableInfo.staticClass, "getSearchActivity", "()Landroid/content/ComponentName;", ref global::android.app.SearchableInfo._getSearchActivity2117) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _shouldRewriteQueryFromData2118;
		public bool shouldRewriteQueryFromData()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromData", "()Z", ref global::android.app.SearchableInfo._shouldRewriteQueryFromData2118);
		}
		internal static global::MonoJavaBridge.MethodId _shouldRewriteQueryFromText2119;
		public bool shouldRewriteQueryFromText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromText", "()Z", ref global::android.app.SearchableInfo._shouldRewriteQueryFromText2119);
		}
		public new int SettingsDescriptionId
		{
			get
			{
				return getSettingsDescriptionId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSettingsDescriptionId2120;
		public int getSettingsDescriptionId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getSettingsDescriptionId", "()I", ref global::android.app.SearchableInfo._getSettingsDescriptionId2120);
		}
		public new global::java.lang.String SuggestPath
		{
			get
			{
				return getSuggestPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestPath2121;
		public global::java.lang.String getSuggestPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestPath", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._getSuggestPath2121) as java.lang.String;
		}
		public new global::java.lang.String SuggestSelection
		{
			get
			{
				return getSuggestSelection();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestSelection2122;
		public global::java.lang.String getSuggestSelection()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestSelection", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._getSuggestSelection2122) as java.lang.String;
		}
		public new global::java.lang.String SuggestIntentAction
		{
			get
			{
				return getSuggestIntentAction();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestIntentAction2123;
		public global::java.lang.String getSuggestIntentAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestIntentAction", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._getSuggestIntentAction2123) as java.lang.String;
		}
		public new global::java.lang.String SuggestIntentData
		{
			get
			{
				return getSuggestIntentData();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestIntentData2124;
		public global::java.lang.String getSuggestIntentData()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestIntentData", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._getSuggestIntentData2124) as java.lang.String;
		}
		public new int SuggestThreshold
		{
			get
			{
				return getSuggestThreshold();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestThreshold2125;
		public int getSuggestThreshold()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getSuggestThreshold", "()I", ref global::android.app.SearchableInfo._getSuggestThreshold2125);
		}
		public new int HintId
		{
			get
			{
				return getHintId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHintId2126;
		public int getHintId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getHintId", "()I", ref global::android.app.SearchableInfo._getHintId2126);
		}
		public new bool VoiceSearchEnabled
		{
			get
			{
				return getVoiceSearchEnabled();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceSearchEnabled2127;
		public bool getVoiceSearchEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceSearchEnabled", "()Z", ref global::android.app.SearchableInfo._getVoiceSearchEnabled2127);
		}
		public new bool VoiceSearchLaunchWebSearch
		{
			get
			{
				return getVoiceSearchLaunchWebSearch();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceSearchLaunchWebSearch2128;
		public bool getVoiceSearchLaunchWebSearch()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchWebSearch", "()Z", ref global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch2128);
		}
		public new bool VoiceSearchLaunchRecognizer
		{
			get
			{
				return getVoiceSearchLaunchRecognizer();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceSearchLaunchRecognizer2129;
		public bool getVoiceSearchLaunchRecognizer()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchRecognizer", "()Z", ref global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer2129);
		}
		public new int VoiceLanguageModeId
		{
			get
			{
				return getVoiceLanguageModeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceLanguageModeId2130;
		public int getVoiceLanguageModeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceLanguageModeId", "()I", ref global::android.app.SearchableInfo._getVoiceLanguageModeId2130);
		}
		public new int VoicePromptTextId
		{
			get
			{
				return getVoicePromptTextId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoicePromptTextId2131;
		public int getVoicePromptTextId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getVoicePromptTextId", "()I", ref global::android.app.SearchableInfo._getVoicePromptTextId2131);
		}
		public new int VoiceLanguageId
		{
			get
			{
				return getVoiceLanguageId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceLanguageId2132;
		public int getVoiceLanguageId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceLanguageId", "()I", ref global::android.app.SearchableInfo._getVoiceLanguageId2132);
		}
		public new int VoiceMaxResults
		{
			get
			{
				return getVoiceMaxResults();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceMaxResults2133;
		public int getVoiceMaxResults()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceMaxResults", "()I", ref global::android.app.SearchableInfo._getVoiceMaxResults2133);
		}
		internal static global::MonoJavaBridge.MethodId _shouldIncludeInGlobalSearch2134;
		public bool shouldIncludeInGlobalSearch()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "shouldIncludeInGlobalSearch", "()Z", ref global::android.app.SearchableInfo._shouldIncludeInGlobalSearch2134);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2135;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.SearchableInfo.staticClass, _CREATOR2135)) as android.os.Parcelable_Creator;
			}
		}
		static SearchableInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.SearchableInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchableInfo"));
			global::android.app.SearchableInfo._CREATOR2135 = @__env.GetStaticFieldIDNoThrow(global::android.app.SearchableInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
