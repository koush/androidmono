namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SearchManager : java.lang.Object, android.content.DialogInterface_OnDismissListener, android.content.DialogInterface_OnCancelListener
	{
		internal static global::java.lang.Class staticClass;
		static SearchManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.SearchManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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

		public partial class OnCancelListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnCancelListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnCancelListener : java.lang.Object, OnCancelListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnCancelListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.SearchManager.__OnCancelListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.app.SearchManager.__OnCancelListener(@__env);
				}
			}
			internal __OnCancelListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onCancel743;
			 void android.app.SearchManager.OnCancelListener.onCancel() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.SearchManager.__OnCancelListener._onCancel743);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.__OnCancelListener.staticClass, global::android.app.SearchManager.__OnCancelListener._onCancel743);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.SearchManager.__OnCancelListener.staticClass = @__class;
				global::android.app.SearchManager.__OnCancelListener._onCancel743 = @__env.GetMethodID(global::android.app.SearchManager.__OnCancelListener.staticClass, "android.app.SearchManager.OnCancelListener.onCancel", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnDismissListener 
		{
			void onDismiss();
		}

		public partial class OnDismissListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnDismissListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnDismissListener : java.lang.Object, OnDismissListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnDismissListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.SearchManager.__OnDismissListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.app.SearchManager.__OnDismissListener(@__env);
				}
			}
			internal __OnDismissListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDismiss744;
			 void android.app.SearchManager.OnDismissListener.onDismiss() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.SearchManager.__OnDismissListener._onDismiss744);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.__OnDismissListener.staticClass, global::android.app.SearchManager.__OnDismissListener._onDismiss744);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.SearchManager.__OnDismissListener.staticClass = @__class;
				global::android.app.SearchManager.__OnDismissListener._onDismiss744 = @__env.GetMethodID(global::android.app.SearchManager.__OnDismissListener.staticClass, "android.app.SearchManager.OnDismissListener.onDismiss", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _startSearch745;
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.content.ComponentName arg2, android.os.Bundle arg3, bool arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._startSearch745, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._startSearch745, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _triggerSearch746;
		public virtual void triggerSearch(java.lang.String arg0, android.content.ComponentName arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._triggerSearch746, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._triggerSearch746, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnCancelListener747;
		public virtual void setOnCancelListener(android.app.SearchManager.OnCancelListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._setOnCancelListener747, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._setOnCancelListener747, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnDismissListener748;
		public virtual void setOnDismissListener(android.app.SearchManager.OnDismissListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._setOnDismissListener748, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._setOnDismissListener748, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCancel749;
		public virtual void onCancel(android.content.DialogInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._onCancel749, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._onCancel749, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDismiss750;
		public virtual void onDismiss(android.content.DialogInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._onDismiss750, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._onDismiss750, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopSearch751;
		public virtual void stopSearch() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._stopSearch751);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._stopSearch751);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSearchableInfo752;
		public virtual global::android.app.SearchableInfo getSearchableInfo(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.SearchableInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.SearchManager._getSearchableInfo752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.SearchableInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._getSearchableInfo752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSearchablesInGlobalSearch753;
		public virtual global::java.util.List getSearchablesInGlobalSearch() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.SearchManager._getSearchablesInGlobalSearch753));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._getSearchablesInGlobalSearch753));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.SearchManager.staticClass = @__class;
			global::android.app.SearchManager._startSearch745 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/content/ComponentName;Landroid/os/Bundle;Z)V");
			global::android.app.SearchManager._triggerSearch746 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/content/ComponentName;Landroid/os/Bundle;)V");
			global::android.app.SearchManager._setOnCancelListener747 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "setOnCancelListener", "(Landroid/app/SearchManager$OnCancelListener;)V");
			global::android.app.SearchManager._setOnDismissListener748 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "setOnDismissListener", "(Landroid/app/SearchManager$OnDismissListener;)V");
			global::android.app.SearchManager._onCancel749 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "onCancel", "(Landroid/content/DialogInterface;)V");
			global::android.app.SearchManager._onDismiss750 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V");
			global::android.app.SearchManager._stopSearch751 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "stopSearch", "()V");
			global::android.app.SearchManager._getSearchableInfo752 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "getSearchableInfo", "(Landroid/content/ComponentName;)Landroid/app/SearchableInfo;");
			global::android.app.SearchManager._getSearchablesInGlobalSearch753 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "getSearchablesInGlobalSearch", "()Ljava/util/List;");
		}
	}
}
