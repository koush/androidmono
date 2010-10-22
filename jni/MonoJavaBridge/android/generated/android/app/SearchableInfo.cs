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
		internal static global::MonoJavaBridge.MethodId _autoUrlDetect2102;
		public bool autoUrlDetect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._autoUrlDetect2102);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._autoUrlDetect2102);
		}
		internal static global::MonoJavaBridge.MethodId _queryAfterZeroResults2103;
		public bool queryAfterZeroResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._queryAfterZeroResults2103);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._queryAfterZeroResults2103);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2104;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchableInfo._writeToParcel2104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._writeToParcel2104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2105;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._describeContents2105);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._describeContents2105);
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType2106;
		public int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getInputType2106);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getInputType2106);
		}
		public new int ImeOptions
		{
			get
			{
				return getImeOptions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImeOptions2107;
		public int getImeOptions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getImeOptions2107);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getImeOptions2107);
		}
		public new global::java.lang.String SuggestAuthority
		{
			get
			{
				return getSuggestAuthority();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestAuthority2108;
		public global::java.lang.String getSuggestAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestAuthority2108)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestAuthority2108)) as java.lang.String;
		}
		public new global::java.lang.String SuggestPackage
		{
			get
			{
				return getSuggestPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestPackage2109;
		public global::java.lang.String getSuggestPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestPackage2109)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestPackage2109)) as java.lang.String;
		}
		public new global::android.content.ComponentName SearchActivity
		{
			get
			{
				return getSearchActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSearchActivity2110;
		public global::android.content.ComponentName getSearchActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSearchActivity2110)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSearchActivity2110)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _shouldRewriteQueryFromData2111;
		public bool shouldRewriteQueryFromData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._shouldRewriteQueryFromData2111);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldRewriteQueryFromData2111);
		}
		internal static global::MonoJavaBridge.MethodId _shouldRewriteQueryFromText2112;
		public bool shouldRewriteQueryFromText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._shouldRewriteQueryFromText2112);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldRewriteQueryFromText2112);
		}
		public new int SettingsDescriptionId
		{
			get
			{
				return getSettingsDescriptionId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSettingsDescriptionId2113;
		public int getSettingsDescriptionId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getSettingsDescriptionId2113);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSettingsDescriptionId2113);
		}
		public new global::java.lang.String SuggestPath
		{
			get
			{
				return getSuggestPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestPath2114;
		public global::java.lang.String getSuggestPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestPath2114)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestPath2114)) as java.lang.String;
		}
		public new global::java.lang.String SuggestSelection
		{
			get
			{
				return getSuggestSelection();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestSelection2115;
		public global::java.lang.String getSuggestSelection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestSelection2115)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestSelection2115)) as java.lang.String;
		}
		public new global::java.lang.String SuggestIntentAction
		{
			get
			{
				return getSuggestIntentAction();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestIntentAction2116;
		public global::java.lang.String getSuggestIntentAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestIntentAction2116)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestIntentAction2116)) as java.lang.String;
		}
		public new global::java.lang.String SuggestIntentData
		{
			get
			{
				return getSuggestIntentData();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestIntentData2117;
		public global::java.lang.String getSuggestIntentData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestIntentData2117)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestIntentData2117)) as java.lang.String;
		}
		public new int SuggestThreshold
		{
			get
			{
				return getSuggestThreshold();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestThreshold2118;
		public int getSuggestThreshold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getSuggestThreshold2118);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getSuggestThreshold2118);
		}
		public new int HintId
		{
			get
			{
				return getHintId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHintId2119;
		public int getHintId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getHintId2119);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getHintId2119);
		}
		public new bool VoiceSearchEnabled
		{
			get
			{
				return getVoiceSearchEnabled();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceSearchEnabled2120;
		public bool getVoiceSearchEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceSearchEnabled2120);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchEnabled2120);
		}
		public new bool VoiceSearchLaunchWebSearch
		{
			get
			{
				return getVoiceSearchLaunchWebSearch();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceSearchLaunchWebSearch2121;
		public bool getVoiceSearchLaunchWebSearch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch2121);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch2121);
		}
		public new bool VoiceSearchLaunchRecognizer
		{
			get
			{
				return getVoiceSearchLaunchRecognizer();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceSearchLaunchRecognizer2122;
		public bool getVoiceSearchLaunchRecognizer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer2122);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer2122);
		}
		public new int VoiceLanguageModeId
		{
			get
			{
				return getVoiceLanguageModeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceLanguageModeId2123;
		public int getVoiceLanguageModeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceLanguageModeId2123);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceLanguageModeId2123);
		}
		public new int VoicePromptTextId
		{
			get
			{
				return getVoicePromptTextId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoicePromptTextId2124;
		public int getVoicePromptTextId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoicePromptTextId2124);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoicePromptTextId2124);
		}
		public new int VoiceLanguageId
		{
			get
			{
				return getVoiceLanguageId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceLanguageId2125;
		public int getVoiceLanguageId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceLanguageId2125);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceLanguageId2125);
		}
		public new int VoiceMaxResults
		{
			get
			{
				return getVoiceMaxResults();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceMaxResults2126;
		public int getVoiceMaxResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.SearchableInfo._getVoiceMaxResults2126);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._getVoiceMaxResults2126);
		}
		internal static global::MonoJavaBridge.MethodId _shouldIncludeInGlobalSearch2127;
		public bool shouldIncludeInGlobalSearch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo._shouldIncludeInGlobalSearch2127);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.SearchableInfo.staticClass, global::android.app.SearchableInfo._shouldIncludeInGlobalSearch2127);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2128;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.SearchableInfo.staticClass, _CREATOR2128)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.SearchableInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchableInfo"));
			global::android.app.SearchableInfo._autoUrlDetect2102 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "autoUrlDetect", "()Z");
			global::android.app.SearchableInfo._queryAfterZeroResults2103 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "queryAfterZeroResults", "()Z");
			global::android.app.SearchableInfo._writeToParcel2104 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.SearchableInfo._describeContents2105 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "describeContents", "()I");
			global::android.app.SearchableInfo._getInputType2106 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getInputType", "()I");
			global::android.app.SearchableInfo._getImeOptions2107 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getImeOptions", "()I");
			global::android.app.SearchableInfo._getSuggestAuthority2108 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestAuthority", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestPackage2109 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestPackage", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSearchActivity2110 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSearchActivity", "()Landroid/content/ComponentName;");
			global::android.app.SearchableInfo._shouldRewriteQueryFromData2111 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromData", "()Z");
			global::android.app.SearchableInfo._shouldRewriteQueryFromText2112 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "shouldRewriteQueryFromText", "()Z");
			global::android.app.SearchableInfo._getSettingsDescriptionId2113 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSettingsDescriptionId", "()I");
			global::android.app.SearchableInfo._getSuggestPath2114 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestPath", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestSelection2115 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestSelection", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestIntentAction2116 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestIntentAction", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestIntentData2117 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestIntentData", "()Ljava/lang/String;");
			global::android.app.SearchableInfo._getSuggestThreshold2118 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getSuggestThreshold", "()I");
			global::android.app.SearchableInfo._getHintId2119 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getHintId", "()I");
			global::android.app.SearchableInfo._getVoiceSearchEnabled2120 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceSearchEnabled", "()Z");
			global::android.app.SearchableInfo._getVoiceSearchLaunchWebSearch2121 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchWebSearch", "()Z");
			global::android.app.SearchableInfo._getVoiceSearchLaunchRecognizer2122 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceSearchLaunchRecognizer", "()Z");
			global::android.app.SearchableInfo._getVoiceLanguageModeId2123 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceLanguageModeId", "()I");
			global::android.app.SearchableInfo._getVoicePromptTextId2124 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoicePromptTextId", "()I");
			global::android.app.SearchableInfo._getVoiceLanguageId2125 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceLanguageId", "()I");
			global::android.app.SearchableInfo._getVoiceMaxResults2126 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "getVoiceMaxResults", "()I");
			global::android.app.SearchableInfo._shouldIncludeInGlobalSearch2127 = @__env.GetMethodIDNoThrow(global::android.app.SearchableInfo.staticClass, "shouldIncludeInGlobalSearch", "()Z");
			global::android.app.SearchableInfo._CREATOR2128 = @__env.GetStaticFieldIDNoThrow(global::android.app.SearchableInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
