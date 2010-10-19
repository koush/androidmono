namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Selection : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Selection()
		{
			InitJNI();
		}
		protected Selection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _selectAll8325;
		public static void selectAll(android.text.Spannable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._selectAll8325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelection8326;
		public static void setSelection(android.text.Spannable arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._setSelection8326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setSelection8327;
		public static void setSelection(android.text.Spannable arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._setSelection8327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionStart8328;
		public static int getSelectionStart(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._getSelectionStart8328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionEnd8329;
		public static int getSelectionEnd(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._getSelectionEnd8329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _extendSelection8330;
		public static void extendSelection(android.text.Spannable arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._extendSelection8330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeSelection8331;
		public static void removeSelection(android.text.Spannable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._removeSelection8331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveUp8332;
		public static bool moveUp(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveUp8332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveDown8333;
		public static bool moveDown(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveDown8333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveLeft8334;
		public static bool moveLeft(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveLeft8334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveRight8335;
		public static bool moveRight(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveRight8335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendUp8336;
		public static bool extendUp(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendUp8336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendDown8337;
		public static bool extendDown(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendDown8337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendLeft8338;
		public static bool extendLeft(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendLeft8338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendRight8339;
		public static bool extendRight(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendRight8339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendToLeftEdge8340;
		public static bool extendToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendToLeftEdge8340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendToRightEdge8341;
		public static bool extendToRightEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendToRightEdge8341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveToLeftEdge8342;
		public static bool moveToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveToLeftEdge8342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveToRightEdge8343;
		public static bool moveToRightEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveToRightEdge8343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.FieldId _SELECTION_START8344;
		public static global::java.lang.Object SELECTION_START
		{
			get
			{
				return default(global::java.lang.Object);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SELECTION_END8345;
		public static global::java.lang.Object SELECTION_END
		{
			get
			{
				return default(global::java.lang.Object);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Selection.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Selection"));
			global::android.text.Selection._selectAll8325 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "selectAll", "(Landroid/text/Spannable;)V");
			global::android.text.Selection._setSelection8326 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;II)V");
			global::android.text.Selection._setSelection8327 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;I)V");
			global::android.text.Selection._getSelectionStart8328 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "getSelectionStart", "(Ljava/lang/CharSequence;)I");
			global::android.text.Selection._getSelectionEnd8329 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "getSelectionEnd", "(Ljava/lang/CharSequence;)I");
			global::android.text.Selection._extendSelection8330 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendSelection", "(Landroid/text/Spannable;I)V");
			global::android.text.Selection._removeSelection8331 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "removeSelection", "(Landroid/text/Spannable;)V");
			global::android.text.Selection._moveUp8332 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveDown8333 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveLeft8334 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveRight8335 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendUp8336 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendDown8337 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendLeft8338 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendRight8339 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendToLeftEdge8340 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendToRightEdge8341 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveToLeftEdge8342 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveToRightEdge8343 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
		}
	}
}
