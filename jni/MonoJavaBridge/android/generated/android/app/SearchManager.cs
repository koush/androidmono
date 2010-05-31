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
			internal static global::net.sf.jni4net.jni.MethodId _onCancel733;
			 void android.app.SearchManager.OnCancelListener.onCancel() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.SearchManager.__OnCancelListener._onCancel733);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.__OnCancelListener.staticClass, global::android.app.SearchManager.__OnCancelListener._onCancel733);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.SearchManager.__OnCancelListener.staticClass = @__class;
				global::android.app.SearchManager.__OnCancelListener._onCancel733 = @__env.GetMethodID(global::android.app.SearchManager.__OnCancelListener.staticClass, "android.app.SearchManager.OnCancelListener.onCancel", "()V");
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
			internal static global::net.sf.jni4net.jni.MethodId _onDismiss734;
			 void android.app.SearchManager.OnDismissListener.onDismiss() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.SearchManager.__OnDismissListener._onDismiss734);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.__OnDismissListener.staticClass, global::android.app.SearchManager.__OnDismissListener._onDismiss734);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.SearchManager.__OnDismissListener.staticClass = @__class;
				global::android.app.SearchManager.__OnDismissListener._onDismiss734 = @__env.GetMethodID(global::android.app.SearchManager.__OnDismissListener.staticClass, "android.app.SearchManager.OnDismissListener.onDismiss", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _startSearch735;
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.content.ComponentName arg2, android.os.Bundle arg3, bool arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._startSearch735, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._startSearch735, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _triggerSearch736;
		public virtual void triggerSearch(java.lang.String arg0, android.content.ComponentName arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._triggerSearch736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._triggerSearch736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnCancelListener737;
		public virtual void setOnCancelListener(android.app.SearchManager.OnCancelListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._setOnCancelListener737, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._setOnCancelListener737, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnDismissListener738;
		public virtual void setOnDismissListener(android.app.SearchManager.OnDismissListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._setOnDismissListener738, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._setOnDismissListener738, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCancel739;
		public virtual void onCancel(android.content.DialogInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._onCancel739, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._onCancel739, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDismiss740;
		public virtual void onDismiss(android.content.DialogInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._onDismiss740, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._onDismiss740, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopSearch741;
		public virtual void stopSearch() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.SearchManager._stopSearch741);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.SearchManager.staticClass, global::android.app.SearchManager._stopSearch741);
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
			global::android.app.SearchManager._startSearch735 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/content/ComponentName;Landroid/os/Bundle;Z)V");
			global::android.app.SearchManager._triggerSearch736 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/content/ComponentName;Landroid/os/Bundle;)V");
			global::android.app.SearchManager._setOnCancelListener737 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "setOnCancelListener", "(Landroid/app/SearchManager$OnCancelListener;)V");
			global::android.app.SearchManager._setOnDismissListener738 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "setOnDismissListener", "(Landroid/app/SearchManager$OnDismissListener;)V");
			global::android.app.SearchManager._onCancel739 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "onCancel", "(Landroid/content/DialogInterface;)V");
			global::android.app.SearchManager._onDismiss740 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V");
			global::android.app.SearchManager._stopSearch741 = @__env.GetMethodID(global::android.app.SearchManager.staticClass, "stopSearch", "()V");
		}
	}
}
