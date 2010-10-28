namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SearchManager : java.lang.Object, android.content.DialogInterface_OnDismissListener, android.content.DialogInterface_OnCancelListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SearchManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.SearchManager.OnCancelListener_))]
		public partial interface OnCancelListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCancel();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.SearchManager.OnCancelListener))]
		internal sealed partial class OnCancelListener_ : java.lang.Object, OnCancelListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnCancelListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCancel2062;
			void android.app.SearchManager.OnCancelListener.onCancel()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager.OnCancelListener_._onCancel2062);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.OnCancelListener_.staticClass, global::android.app.SearchManager.OnCancelListener_._onCancel2062);
			}
			static OnCancelListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.SearchManager.OnCancelListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchManager$OnCancelListener"));
				global::android.app.SearchManager.OnCancelListener_._onCancel2062 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.OnCancelListener_.staticClass, "onCancel", "()V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnCancelListenerDelegate();

		internal partial class OnCancelListenerDelegateWrapper : java.lang.Object, OnCancelListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnCancelListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnCancelListenerDelegateWrapper2063;
			public OnCancelListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.SearchManager.OnCancelListenerDelegateWrapper.staticClass, global::android.app.SearchManager.OnCancelListenerDelegateWrapper._OnCancelListenerDelegateWrapper2063);
				Init(@__env, handle);
			}
			static OnCancelListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.SearchManager.OnCancelListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchManager_OnCancelListenerDelegateWrapper"));
				global::android.app.SearchManager.OnCancelListenerDelegateWrapper._OnCancelListenerDelegateWrapper2063 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.OnCancelListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnCancelListenerDelegateWrapper
		{
			private OnCancelListenerDelegate myDelegate;
			public void onCancel()
			{
				myDelegate();
			}
			public static implicit operator OnCancelListenerDelegateWrapper(OnCancelListenerDelegate d)
			{
				global::android.app.SearchManager.OnCancelListenerDelegateWrapper ret = new global::android.app.SearchManager.OnCancelListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.SearchManager.OnDismissListener_))]
		public partial interface OnDismissListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDismiss();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.SearchManager.OnDismissListener))]
		internal sealed partial class OnDismissListener_ : java.lang.Object, OnDismissListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnDismissListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDismiss2064;
			void android.app.SearchManager.OnDismissListener.onDismiss()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager.OnDismissListener_._onDismiss2064);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.OnDismissListener_.staticClass, global::android.app.SearchManager.OnDismissListener_._onDismiss2064);
			}
			static OnDismissListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.SearchManager.OnDismissListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchManager$OnDismissListener"));
				global::android.app.SearchManager.OnDismissListener_._onDismiss2064 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.OnDismissListener_.staticClass, "onDismiss", "()V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnDismissListenerDelegate();

		internal partial class OnDismissListenerDelegateWrapper : java.lang.Object, OnDismissListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnDismissListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnDismissListenerDelegateWrapper2065;
			public OnDismissListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.SearchManager.OnDismissListenerDelegateWrapper.staticClass, global::android.app.SearchManager.OnDismissListenerDelegateWrapper._OnDismissListenerDelegateWrapper2065);
				Init(@__env, handle);
			}
			static OnDismissListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.SearchManager.OnDismissListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchManager_OnDismissListenerDelegateWrapper"));
				global::android.app.SearchManager.OnDismissListenerDelegateWrapper._OnDismissListenerDelegateWrapper2065 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.OnDismissListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnDismissListenerDelegateWrapper
		{
			private OnDismissListenerDelegate myDelegate;
			public void onDismiss()
			{
				myDelegate();
			}
			public static implicit operator OnDismissListenerDelegateWrapper(OnDismissListenerDelegate d)
			{
				global::android.app.SearchManager.OnDismissListenerDelegateWrapper ret = new global::android.app.SearchManager.OnDismissListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _startSearch2066;
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.content.ComponentName arg2, android.os.Bundle arg3, bool arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._startSearch2066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._startSearch2066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _triggerSearch2067;
		public virtual void triggerSearch(java.lang.String arg0, android.content.ComponentName arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._triggerSearch2067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._triggerSearch2067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCancelListener2068;
		public virtual void setOnCancelListener(android.app.SearchManager.OnCancelListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._setOnCancelListener2068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._setOnCancelListener2068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnCancelListener(global::android.app.SearchManager.OnCancelListenerDelegate arg0)
		{
			setOnCancelListener((global::android.app.SearchManager.OnCancelListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnDismissListener2069;
		public virtual void setOnDismissListener(android.app.SearchManager.OnDismissListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._setOnDismissListener2069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._setOnDismissListener2069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnDismissListener(global::android.app.SearchManager.OnDismissListenerDelegate arg0)
		{
			setOnDismissListener((global::android.app.SearchManager.OnDismissListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _onCancel2070;
		public virtual void onCancel(android.content.DialogInterface arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._onCancel2070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._onCancel2070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDismiss2071;
		public virtual void onDismiss(android.content.DialogInterface arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._onDismiss2071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._onDismiss2071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopSearch2072;
		public virtual void stopSearch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._stopSearch2072);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._stopSearch2072);
		}
		internal static global::MonoJavaBridge.MethodId _getSearchableInfo2073;
		public virtual global::android.app.SearchableInfo getSearchableInfo(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.SearchableInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchManager._getSearchableInfo2073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.SearchableInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.SearchableInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._getSearchableInfo2073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.SearchableInfo;
		}
		public new global::java.util.List SearchablesInGlobalSearch
		{
			get
			{
				return getSearchablesInGlobalSearch();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSearchablesInGlobalSearch2074;
		public virtual global::java.util.List getSearchablesInGlobalSearch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchManager._getSearchablesInGlobalSearch2074)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._getSearchablesInGlobalSearch2074)) as java.util.List;
		}
		public static char MENU_KEY
		{
			get
			{
				return 's';
			}
		}
		public static int MENU_KEYCODE
		{
			get
			{
				return 47;
			}
		}
		public static global::java.lang.String QUERY
		{
			get
			{
				return "query";
			}
		}
		public static global::java.lang.String USER_QUERY
		{
			get
			{
				return "user_query";
			}
		}
		public static global::java.lang.String APP_DATA
		{
			get
			{
				return "app_data";
			}
		}
		public static global::java.lang.String ACTION_KEY
		{
			get
			{
				return "action_key";
			}
		}
		public static global::java.lang.String EXTRA_DATA_KEY
		{
			get
			{
				return "intent_extra_data_key";
			}
		}
		public static global::java.lang.String EXTRA_SELECT_QUERY
		{
			get
			{
				return "select_query";
			}
		}
		public static global::java.lang.String CURSOR_EXTRA_KEY_IN_PROGRESS
		{
			get
			{
				return "in_progress";
			}
		}
		public static global::java.lang.String ACTION_MSG
		{
			get
			{
				return "action_msg";
			}
		}
		public static global::java.lang.String SUGGEST_URI_PATH_QUERY
		{
			get
			{
				return "search_suggest_query";
			}
		}
		public static global::java.lang.String SUGGEST_MIME_TYPE
		{
			get
			{
				return "vnd.android.cursor.dir/vnd.android.search.suggest";
			}
		}
		public static global::java.lang.String SUGGEST_URI_PATH_SHORTCUT
		{
			get
			{
				return "search_suggest_shortcut";
			}
		}
		public static global::java.lang.String SHORTCUT_MIME_TYPE
		{
			get
			{
				return "vnd.android.cursor.item/vnd.android.search.suggest";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_FORMAT
		{
			get
			{
				return "suggest_format";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_TEXT_1
		{
			get
			{
				return "suggest_text_1";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_TEXT_2
		{
			get
			{
				return "suggest_text_2";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_TEXT_2_URL
		{
			get
			{
				return "suggest_text_2_url";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_ICON_1
		{
			get
			{
				return "suggest_icon_1";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_ICON_2
		{
			get
			{
				return "suggest_icon_2";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_INTENT_ACTION
		{
			get
			{
				return "suggest_intent_action";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_INTENT_DATA
		{
			get
			{
				return "suggest_intent_data";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_INTENT_EXTRA_DATA
		{
			get
			{
				return "suggest_intent_extra_data";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_INTENT_DATA_ID
		{
			get
			{
				return "suggest_intent_data_id";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_QUERY
		{
			get
			{
				return "suggest_intent_query";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_SHORTCUT_ID
		{
			get
			{
				return "suggest_shortcut_id";
			}
		}
		public static global::java.lang.String SUGGEST_COLUMN_SPINNER_WHILE_REFRESHING
		{
			get
			{
				return "suggest_spinner_while_refreshing";
			}
		}
		public static global::java.lang.String SUGGEST_NEVER_MAKE_SHORTCUT
		{
			get
			{
				return "_-1";
			}
		}
		public static global::java.lang.String SUGGEST_PARAMETER_LIMIT
		{
			get
			{
				return "limit";
			}
		}
		public static global::java.lang.String INTENT_ACTION_GLOBAL_SEARCH
		{
			get
			{
				return "android.search.action.GLOBAL_SEARCH";
			}
		}
		public static global::java.lang.String INTENT_ACTION_SEARCH_SETTINGS
		{
			get
			{
				return "android.search.action.SEARCH_SETTINGS";
			}
		}
		public static global::java.lang.String INTENT_ACTION_WEB_SEARCH_SETTINGS
		{
			get
			{
				return "android.search.action.WEB_SEARCH_SETTINGS";
			}
		}
		public static global::java.lang.String INTENT_ACTION_SEARCHABLES_CHANGED
		{
			get
			{
				return "android.search.action.SEARCHABLES_CHANGED";
			}
		}
		public static global::java.lang.String INTENT_ACTION_SEARCH_SETTINGS_CHANGED
		{
			get
			{
				return "android.search.action.SETTINGS_CHANGED";
			}
		}
		static SearchManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.SearchManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchManager"));
			global::android.app.SearchManager._startSearch2066 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/content/ComponentName;Landroid/os/Bundle;Z)V");
			global::android.app.SearchManager._triggerSearch2067 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/content/ComponentName;Landroid/os/Bundle;)V");
			global::android.app.SearchManager._setOnCancelListener2068 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "setOnCancelListener", "(Landroid/app/SearchManager$OnCancelListener;)V");
			global::android.app.SearchManager._setOnDismissListener2069 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "setOnDismissListener", "(Landroid/app/SearchManager$OnDismissListener;)V");
			global::android.app.SearchManager._onCancel2070 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "onCancel", "(Landroid/content/DialogInterface;)V");
			global::android.app.SearchManager._onDismiss2071 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V");
			global::android.app.SearchManager._stopSearch2072 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "stopSearch", "()V");
			global::android.app.SearchManager._getSearchableInfo2073 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "getSearchableInfo", "(Landroid/content/ComponentName;)Landroid/app/SearchableInfo;");
			global::android.app.SearchManager._getSearchablesInGlobalSearch2074 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "getSearchablesInGlobalSearch", "()Ljava/util/List;");
		}
		internal static void InitJNI()
		{
		}
	}
}
