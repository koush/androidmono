namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class LiveFolders : java.lang.Object, BaseColumns
	{ 
		internal static global::java.lang.Class staticClass; 
		static LiveFolders() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.LiveFolders), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.provider.LiveFolders(@__env); 
			} 
		} 
		internal LiveFolders(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		public static java.lang.String NAME
		{ 
			get 
			{ 
				return "name"; 
			} 
		} 
		public static java.lang.String DESCRIPTION
		{ 
			get 
			{ 
				return "description"; 
			} 
		} 
		public static java.lang.String INTENT
		{ 
			get 
			{ 
				return "intent"; 
			} 
		} 
		public static java.lang.String ICON_BITMAP
		{ 
			get 
			{ 
				return "icon_bitmap"; 
			} 
		} 
		public static java.lang.String ICON_PACKAGE
		{ 
			get 
			{ 
				return "icon_package"; 
			} 
		} 
		public static java.lang.String ICON_RESOURCE
		{ 
			get 
			{ 
				return "icon_resource"; 
			} 
		} 
		public static int DISPLAY_MODE_GRID
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int DISPLAY_MODE_LIST
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static java.lang.String EXTRA_LIVE_FOLDER_NAME
		{ 
			get 
			{ 
				return "android.intent.extra.livefolder.NAME"; 
			} 
		} 
		public static java.lang.String EXTRA_LIVE_FOLDER_ICON
		{ 
			get 
			{ 
				return "android.intent.extra.livefolder.ICON"; 
			} 
		} 
		public static java.lang.String EXTRA_LIVE_FOLDER_DISPLAY_MODE
		{ 
			get 
			{ 
				return "android.intent.extra.livefolder.DISPLAY_MODE"; 
			} 
		} 
		public static java.lang.String EXTRA_LIVE_FOLDER_BASE_INTENT
		{ 
			get 
			{ 
				return "android.intent.extra.livefolder.BASE_INTENT"; 
			} 
		} 
		public static java.lang.String ACTION_CREATE_LIVE_FOLDER
		{ 
			get 
			{ 
				return "android.intent.action.CREATE_LIVE_FOLDER"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.LiveFolders.staticClass = @__class; 
		} 
	} 
} 
