namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SearchManager : java.lang.Object, android.content.DialogInterface_OnDismissListener, android.content.DialogInterface_OnCancelListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SearchManager()
		{
			InitJNI();
		}
		protected SearchManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.SearchManager.OnCancelListener_))]
		public interface OnCancelListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCancel();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.SearchManager.OnCancelListener))]
		public sealed partial class OnCancelListener_ : java.lang.Object, OnCancelListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnCancelListener_()
			{
				InitJNI();
			}
			internal OnCancelListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCancel753;
			 void android.app.SearchManager.OnCancelListener.onCancel() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager.OnCancelListener_._onCancel753);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.OnCancelListener_.staticClass, global::android.app.SearchManager.OnCancelListener_._onCancel753);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.SearchManager.OnCancelListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchManager$OnCancelListener"));
				global::android.app.SearchManager.OnCancelListener_._onCancel753 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.OnCancelListener_.staticClass, "onCancel", "()V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.SearchManager.OnDismissListener_))]
		public interface OnDismissListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDismiss();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.SearchManager.OnDismissListener))]
		public sealed partial class OnDismissListener_ : java.lang.Object, OnDismissListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDismissListener_()
			{
				InitJNI();
			}
			internal OnDismissListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDismiss754;
			 void android.app.SearchManager.OnDismissListener.onDismiss() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager.OnDismissListener_._onDismiss754);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.OnDismissListener_.staticClass, global::android.app.SearchManager.OnDismissListener_._onDismiss754);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.SearchManager.OnDismissListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchManager$OnDismissListener"));
				global::android.app.SearchManager.OnDismissListener_._onDismiss754 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.OnDismissListener_.staticClass, "onDismiss", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _startSearch755;
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.content.ComponentName arg2, android.os.Bundle arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._startSearch755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._startSearch755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _triggerSearch756;
		public virtual void triggerSearch(java.lang.String arg0, android.content.ComponentName arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._triggerSearch756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._triggerSearch756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCancelListener757;
		public virtual void setOnCancelListener(android.app.SearchManager.OnCancelListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._setOnCancelListener757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._setOnCancelListener757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnDismissListener758;
		public virtual void setOnDismissListener(android.app.SearchManager.OnDismissListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._setOnDismissListener758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._setOnDismissListener758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCancel759;
		public virtual void onCancel(android.content.DialogInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._onCancel759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._onCancel759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDismiss760;
		public virtual void onDismiss(android.content.DialogInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._onDismiss760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._onDismiss760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopSearch761;
		public virtual void stopSearch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.SearchManager._stopSearch761);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._stopSearch761);
		}
		internal static global::MonoJavaBridge.MethodId _getSearchableInfo762;
		public virtual global::android.app.SearchableInfo getSearchableInfo(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchManager._getSearchableInfo762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.SearchableInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._getSearchableInfo762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.SearchableInfo;
		}
		public new global::java.util.List SearchablesInGlobalSearch
		{
			get
			{
				return getSearchablesInGlobalSearch();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSearchablesInGlobalSearch763;
		public virtual global::java.util.List getSearchablesInGlobalSearch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.SearchManager._getSearchablesInGlobalSearch763)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._getSearchablesInGlobalSearch763)) as java.util.List;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.SearchManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/SearchManager"));
			global::android.app.SearchManager._startSearch755 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/content/ComponentName;Landroid/os/Bundle;Z)V");
			global::android.app.SearchManager._triggerSearch756 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/content/ComponentName;Landroid/os/Bundle;)V");
			global::android.app.SearchManager._setOnCancelListener757 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "setOnCancelListener", "(Landroid/app/SearchManager$OnCancelListener;)V");
			global::android.app.SearchManager._setOnDismissListener758 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "setOnDismissListener", "(Landroid/app/SearchManager$OnDismissListener;)V");
			global::android.app.SearchManager._onCancel759 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "onCancel", "(Landroid/content/DialogInterface;)V");
			global::android.app.SearchManager._onDismiss760 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V");
			global::android.app.SearchManager._stopSearch761 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "stopSearch", "()V");
			global::android.app.SearchManager._getSearchableInfo762 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "getSearchableInfo", "(Landroid/content/ComponentName;)Landroid/app/SearchableInfo;");
			global::android.app.SearchManager._getSearchablesInGlobalSearch763 = @__env.GetMethodIDNoThrow(global::android.app.SearchManager.staticClass, "getSearchablesInGlobalSearch", "()Ljava/util/List;");
		}
	}
}
