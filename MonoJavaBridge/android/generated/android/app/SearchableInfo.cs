namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SearchableInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SearchableInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public bool autoUrlDetect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "autoUrlDetect", "()Z", ref global::android.app.SearchableInfo._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public bool queryAfterZeroResults()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "queryAfterZeroResults", "()Z", ref global::android.app.SearchableInfo._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.SearchableInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.SearchableInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "describeContents", "()I", ref global::android.app.SearchableInfo._m3);
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getInputType", "()I", ref global::android.app.SearchableInfo._m4);
		}
		public new int ImeOptions
		{
			get
			{
				return getImeOptions();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int getImeOptions()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getImeOptions", "()I", ref global::android.app.SearchableInfo._m5);
		}
		public new global::java.lang.String SuggestAuthority
		{
			get
			{
				return getSuggestAuthority();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.String getSuggestAuthority()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestAuthority", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._m6) as java.lang.String;
		}
		public new global::java.lang.String SuggestPackage
		{
			get
			{
				return getSuggestPackage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.lang.String getSuggestPackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestPackage", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._m7) as java.lang.String;
		}
		public new global::android.content.ComponentName SearchActivity
		{
			get
			{
				return getSearchActivity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::android.content.ComponentName getSearchActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.app.SearchableInfo.staticClass, "getSearchActivity", "()Landroid/content/ComponentName;", ref global::android.app.SearchableInfo._m8) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public bool shouldRewriteQueryFromData()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromData", "()Z", ref global::android.app.SearchableInfo._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public bool shouldRewriteQueryFromText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromText", "()Z", ref global::android.app.SearchableInfo._m10);
		}
		public new int SettingsDescriptionId
		{
			get
			{
				return getSettingsDescriptionId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public int getSettingsDescriptionId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getSettingsDescriptionId", "()I", ref global::android.app.SearchableInfo._m11);
		}
		public new global::java.lang.String SuggestPath
		{
			get
			{
				return getSuggestPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.lang.String getSuggestPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestPath", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._m12) as java.lang.String;
		}
		public new global::java.lang.String SuggestSelection
		{
			get
			{
				return getSuggestSelection();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.lang.String getSuggestSelection()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestSelection", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._m13) as java.lang.String;
		}
		public new global::java.lang.String SuggestIntentAction
		{
			get
			{
				return getSuggestIntentAction();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::java.lang.String getSuggestIntentAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestIntentAction", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._m14) as java.lang.String;
		}
		public new global::java.lang.String SuggestIntentData
		{
			get
			{
				return getSuggestIntentData();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public global::java.lang.String getSuggestIntentData()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.SearchableInfo.staticClass, "getSuggestIntentData", "()Ljava/lang/String;", ref global::android.app.SearchableInfo._m15) as java.lang.String;
		}
		public new int SuggestThreshold
		{
			get
			{
				return getSuggestThreshold();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public int getSuggestThreshold()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getSuggestThreshold", "()I", ref global::android.app.SearchableInfo._m16);
		}
		public new int HintId
		{
			get
			{
				return getHintId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public int getHintId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getHintId", "()I", ref global::android.app.SearchableInfo._m17);
		}
		public new bool VoiceSearchEnabled
		{
			get
			{
				return getVoiceSearchEnabled();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public bool getVoiceSearchEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceSearchEnabled", "()Z", ref global::android.app.SearchableInfo._m18);
		}
		public new bool VoiceSearchLaunchWebSearch
		{
			get
			{
				return getVoiceSearchLaunchWebSearch();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public bool getVoiceSearchLaunchWebSearch()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchWebSearch", "()Z", ref global::android.app.SearchableInfo._m19);
		}
		public new bool VoiceSearchLaunchRecognizer
		{
			get
			{
				return getVoiceSearchLaunchRecognizer();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public bool getVoiceSearchLaunchRecognizer()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchRecognizer", "()Z", ref global::android.app.SearchableInfo._m20);
		}
		public new int VoiceLanguageModeId
		{
			get
			{
				return getVoiceLanguageModeId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public int getVoiceLanguageModeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceLanguageModeId", "()I", ref global::android.app.SearchableInfo._m21);
		}
		public new int VoicePromptTextId
		{
			get
			{
				return getVoicePromptTextId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public int getVoicePromptTextId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getVoicePromptTextId", "()I", ref global::android.app.SearchableInfo._m22);
		}
		public new int VoiceLanguageId
		{
			get
			{
				return getVoiceLanguageId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public int getVoiceLanguageId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceLanguageId", "()I", ref global::android.app.SearchableInfo._m23);
		}
		public new int VoiceMaxResults
		{
			get
			{
				return getVoiceMaxResults();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public int getVoiceMaxResults()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.SearchableInfo.staticClass, "getVoiceMaxResults", "()I", ref global::android.app.SearchableInfo._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public bool shouldIncludeInGlobalSearch()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.SearchableInfo.staticClass, "shouldIncludeInGlobalSearch", "()Z", ref global::android.app.SearchableInfo._m25);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1430;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.SearchableInfo.staticClass, _CREATOR1430)) as android.os.Parcelable_Creator;
			}
		}
		static SearchableInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.SearchableInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchableInfo"));
			global::android.app.SearchableInfo._CREATOR1430 = @__env.GetStaticFieldIDNoThrow(global::android.app.SearchableInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
