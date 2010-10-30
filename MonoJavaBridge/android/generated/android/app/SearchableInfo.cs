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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._autoUrlDetect2109.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._autoUrlDetect2109 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "autoUrlDetect", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._autoUrlDetect2109);
		}
		internal static global::MonoJavaBridge.MethodId _queryAfterZeroResults2110;
		public bool queryAfterZeroResults()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._queryAfterZeroResults2110.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._queryAfterZeroResults2110 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "queryAfterZeroResults", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._queryAfterZeroResults2110);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2111;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._writeToParcel2111.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._writeToParcel2111 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._writeToParcel2111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2112;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._describeContents2112.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._describeContents2112 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "describeContents", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._describeContents2112);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getInputType2113.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getInputType2113 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getInputType", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getInputType2113);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getImeOptions2114.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getImeOptions2114 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getImeOptions", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getImeOptions2114);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getSuggestAuthority2115.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getSuggestAuthority2115 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestAuthority", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestAuthority2115)) as java.lang.String;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getSuggestPackage2116.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getSuggestPackage2116 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestPackage", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestPackage2116)) as java.lang.String;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getSearchActivity2117.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getSearchActivity2117 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSearchActivity", "()Landroid/content/ComponentName;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSearchActivity2117)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _shouldRewriteQueryFromData2118;
		public bool shouldRewriteQueryFromData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._shouldRewriteQueryFromData2118.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._shouldRewriteQueryFromData2118 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromData", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldRewriteQueryFromData2118);
		}
		internal static global::MonoJavaBridge.MethodId _shouldRewriteQueryFromText2119;
		public bool shouldRewriteQueryFromText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._shouldRewriteQueryFromText2119.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._shouldRewriteQueryFromText2119 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromText", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldRewriteQueryFromText2119);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getSettingsDescriptionId2120.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getSettingsDescriptionId2120 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSettingsDescriptionId", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSettingsDescriptionId2120);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getSuggestPath2121.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getSuggestPath2121 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestPath", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestPath2121)) as java.lang.String;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getSuggestSelection2122.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getSuggestSelection2122 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestSelection", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestSelection2122)) as java.lang.String;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getSuggestIntentAction2123.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getSuggestIntentAction2123 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestIntentAction", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestIntentAction2123)) as java.lang.String;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getSuggestIntentData2124.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getSuggestIntentData2124 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestIntentData", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestIntentData2124)) as java.lang.String;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getSuggestThreshold2125.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getSuggestThreshold2125 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestThreshold", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestThreshold2125);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getHintId2126.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getHintId2126 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getHintId", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getHintId2126);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getVoiceSearchEnabled2127.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getVoiceSearchEnabled2127 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceSearchEnabled", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchEnabled2127);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch2128.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch2128 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchWebSearch", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch2128);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer2129.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer2129 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchRecognizer", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer2129);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getVoiceLanguageModeId2130.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getVoiceLanguageModeId2130 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceLanguageModeId", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceLanguageModeId2130);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getVoicePromptTextId2131.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getVoicePromptTextId2131 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoicePromptTextId", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoicePromptTextId2131);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getVoiceLanguageId2132.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getVoiceLanguageId2132 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceLanguageId", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceLanguageId2132);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._getVoiceMaxResults2133.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._getVoiceMaxResults2133 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceMaxResults", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceMaxResults2133);
		}
		internal static global::MonoJavaBridge.MethodId _shouldIncludeInGlobalSearch2134;
		public bool shouldIncludeInGlobalSearch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.SearchableInfo._shouldIncludeInGlobalSearch2134.native == global::System.IntPtr.Zero)
				global::android.app.SearchableInfo._shouldIncludeInGlobalSearch2134 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "shouldIncludeInGlobalSearch", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldIncludeInGlobalSearch2134);
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
