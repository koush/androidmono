namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class LiveFolders : java.lang.Object, BaseColumns
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LiveFolders()
		{
			InitJNI();
		}
		internal LiveFolders(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::java.lang.String NAME
		{
			get
			{
				return "name";
			}
		}
		public static global::java.lang.String DESCRIPTION
		{
			get
			{
				return "description";
			}
		}
		public static global::java.lang.String INTENT
		{
			get
			{
				return "intent";
			}
		}
		public static global::java.lang.String ICON_BITMAP
		{
			get
			{
				return "icon_bitmap";
			}
		}
		public static global::java.lang.String ICON_PACKAGE
		{
			get
			{
				return "icon_package";
			}
		}
		public static global::java.lang.String ICON_RESOURCE
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
		public static global::java.lang.String EXTRA_LIVE_FOLDER_NAME
		{
			get
			{
				return "android.intent.extra.livefolder.NAME";
			}
		}
		public static global::java.lang.String EXTRA_LIVE_FOLDER_ICON
		{
			get
			{
				return "android.intent.extra.livefolder.ICON";
			}
		}
		public static global::java.lang.String EXTRA_LIVE_FOLDER_DISPLAY_MODE
		{
			get
			{
				return "android.intent.extra.livefolder.DISPLAY_MODE";
			}
		}
		public static global::java.lang.String EXTRA_LIVE_FOLDER_BASE_INTENT
		{
			get
			{
				return "android.intent.extra.livefolder.BASE_INTENT";
			}
		}
		public static global::java.lang.String ACTION_CREATE_LIVE_FOLDER
		{
			get
			{
				return "android.intent.action.CREATE_LIVE_FOLDER";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.LiveFolders.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/LiveFolders"));
		}
	}
}
