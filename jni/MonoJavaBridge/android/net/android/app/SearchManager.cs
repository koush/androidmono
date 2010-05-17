namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SearchManager : java.lang.Object, android.content.DialogInterface_OnDismissListener, android.content.DialogInterface_OnCancelListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static SearchManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.SearchManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.SearchManager(@__env); 
			} 
		} 
		protected SearchManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnCancelListener 
		{ 
			void onCancel(); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnDismissListener 
		{ 
			void onDismiss(); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startSearch723; 
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.content.ComponentName arg2, android.os.Bundle arg3, bool arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.SearchManager)) 
				@__env.CallVoidMethod(this, _startSearch723, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.SearchManager.staticClass, _startSearch723, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _triggerSearch724; 
		public virtual void triggerSearch(java.lang.String arg0, android.content.ComponentName arg1, android.os.Bundle arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.SearchManager)) 
				@__env.CallVoidMethod(this, _triggerSearch724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.SearchManager.staticClass, _triggerSearch724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnCancelListener725; 
		public virtual void setOnCancelListener(android.app.SearchManager.OnCancelListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.SearchManager)) 
				@__env.CallVoidMethod(this, _setOnCancelListener725, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.SearchManager.staticClass, _setOnCancelListener725, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnDismissListener726; 
		public virtual void setOnDismissListener(android.app.SearchManager.OnDismissListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.SearchManager)) 
				@__env.CallVoidMethod(this, _setOnDismissListener726, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.SearchManager.staticClass, _setOnDismissListener726, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCancel727; 
		public virtual void onCancel(android.content.DialogInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.SearchManager)) 
				@__env.CallVoidMethod(this, _onCancel727, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.SearchManager.staticClass, _onCancel727, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDismiss728; 
		public virtual void onDismiss(android.content.DialogInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.SearchManager)) 
				@__env.CallVoidMethod(this, _onDismiss728, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.SearchManager.staticClass, _onDismiss728, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopSearch729; 
		public virtual void stopSearch() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.SearchManager)) 
				@__env.CallVoidMethod(this, _stopSearch729); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.SearchManager.staticClass, _stopSearch729); 
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
		public static java.lang.String QUERY
		{ 
			get 
			{ 
				return "query"; 
			} 
		} 
		public static java.lang.String USER_QUERY
		{ 
			get 
			{ 
				return "user_query"; 
			} 
		} 
		public static java.lang.String APP_DATA
		{ 
			get 
			{ 
				return "app_data"; 
			} 
		} 
		public static java.lang.String ACTION_KEY
		{ 
			get 
			{ 
				return "action_key"; 
			} 
		} 
		public static java.lang.String EXTRA_DATA_KEY
		{ 
			get 
			{ 
				return "intent_extra_data_key"; 
			} 
		} 
		public static java.lang.String ACTION_MSG
		{ 
			get 
			{ 
				return "action_msg"; 
			} 
		} 
		public static java.lang.String SUGGEST_URI_PATH_QUERY
		{ 
			get 
			{ 
				return "search_suggest_query"; 
			} 
		} 
		public static java.lang.String SUGGEST_MIME_TYPE
		{ 
			get 
			{ 
				return "vnd.android.cursor.dir/vnd.android.search.suggest"; 
			} 
		} 
		public static java.lang.String SUGGEST_URI_PATH_SHORTCUT
		{ 
			get 
			{ 
				return "search_suggest_shortcut"; 
			} 
		} 
		public static java.lang.String SHORTCUT_MIME_TYPE
		{ 
			get 
			{ 
				return "vnd.android.cursor.item/vnd.android.search.suggest"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_FORMAT
		{ 
			get 
			{ 
				return "suggest_format"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_TEXT_1
		{ 
			get 
			{ 
				return "suggest_text_1"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_TEXT_2
		{ 
			get 
			{ 
				return "suggest_text_2"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_ICON_1
		{ 
			get 
			{ 
				return "suggest_icon_1"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_ICON_2
		{ 
			get 
			{ 
				return "suggest_icon_2"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_INTENT_ACTION
		{ 
			get 
			{ 
				return "suggest_intent_action"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_INTENT_DATA
		{ 
			get 
			{ 
				return "suggest_intent_data"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_INTENT_EXTRA_DATA
		{ 
			get 
			{ 
				return "suggest_intent_extra_data"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_INTENT_DATA_ID
		{ 
			get 
			{ 
				return "suggest_intent_data_id"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_QUERY
		{ 
			get 
			{ 
				return "suggest_intent_query"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_SHORTCUT_ID
		{ 
			get 
			{ 
				return "suggest_shortcut_id"; 
			} 
		} 
		public static java.lang.String SUGGEST_COLUMN_SPINNER_WHILE_REFRESHING
		{ 
			get 
			{ 
				return "suggest_spinner_while_refreshing"; 
			} 
		} 
		public static java.lang.String SUGGEST_NEVER_MAKE_SHORTCUT
		{ 
			get 
			{ 
				return "_-1"; 
			} 
		} 
		public static java.lang.String SUGGEST_PARAMETER_LIMIT
		{ 
			get 
			{ 
				return "limit"; 
			} 
		} 
		public static java.lang.String INTENT_ACTION_WEB_SEARCH_SETTINGS
		{ 
			get 
			{ 
				return "android.search.action.WEB_SEARCH_SETTINGS"; 
			} 
		} 
		public static java.lang.String INTENT_ACTION_SEARCHABLES_CHANGED
		{ 
			get 
			{ 
				return "android.search.action.SEARCHABLES_CHANGED"; 
			} 
		} 
		public static java.lang.String INTENT_ACTION_SEARCH_SETTINGS_CHANGED
		{ 
			get 
			{ 
				return "android.search.action.SETTINGS_CHANGED"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.SearchManager.staticClass = @__class; 
			global::android.app.SearchManager._startSearch723 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/content/ComponentName;Landroid/os/Bundle;Z)V"); 
			global::android.app.SearchManager._triggerSearch724 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/content/ComponentName;Landroid/os/Bundle;)V"); 
			global::android.app.SearchManager._setOnCancelListener725 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "setOnCancelListener", "(Landroid/app/SearchManager$OnCancelListener;)V"); 
			global::android.app.SearchManager._setOnDismissListener726 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "setOnDismissListener", "(Landroid/app/SearchManager$OnDismissListener;)V"); 
			global::android.app.SearchManager._onCancel727 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "onCancel", "(Landroid/content/DialogInterface;)V"); 
			global::android.app.SearchManager._onDismiss728 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V"); 
			global::android.app.SearchManager._stopSearch729 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "stopSearch", "()V"); 
		} 
	} 
} 
