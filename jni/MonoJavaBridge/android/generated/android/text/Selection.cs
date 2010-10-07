namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Selection : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Selection()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.Selection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.Selection(@__env);
			}
		}
		protected Selection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _selectAll7487;
		public static void selectAll(android.text.Spannable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._selectAll7487, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection7488;
		public static void setSelection(android.text.Spannable arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._setSelection7488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection7489;
		public static void setSelection(android.text.Spannable arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._setSelection7489, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionStart7490;
		public static int getSelectionStart(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._getSelectionStart7490, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionEnd7491;
		public static int getSelectionEnd(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._getSelectionEnd7491, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendSelection7492;
		public static void extendSelection(android.text.Spannable arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._extendSelection7492, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeSelection7493;
		public static void removeSelection(android.text.Spannable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._removeSelection7493, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveUp7494;
		public static bool moveUp(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveUp7494, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveDown7495;
		public static bool moveDown(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveDown7495, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveLeft7496;
		public static bool moveLeft(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveLeft7496, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveRight7497;
		public static bool moveRight(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveRight7497, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendUp7498;
		public static bool extendUp(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendUp7498, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendDown7499;
		public static bool extendDown(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendDown7499, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendLeft7500;
		public static bool extendLeft(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendLeft7500, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendRight7501;
		public static bool extendRight(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendRight7501, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendToLeftEdge7502;
		public static bool extendToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendToLeftEdge7502, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendToRightEdge7503;
		public static bool extendToRightEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendToRightEdge7503, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToLeftEdge7504;
		public static bool moveToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveToLeftEdge7504, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToRightEdge7505;
		public static bool moveToRightEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveToRightEdge7505, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.FieldId _SELECTION_START7506;
		public static global::java.lang.Object SELECTION_START
		{
			get
			{
				return default(global::java.lang.Object);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _SELECTION_END7507;
		public static global::java.lang.Object SELECTION_END
		{
			get
			{
				return default(global::java.lang.Object);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.Selection.staticClass = @__class;
			global::android.text.Selection._selectAll7487 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "selectAll", "(Landroid/text/Spannable;)V");
			global::android.text.Selection._setSelection7488 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;II)V");
			global::android.text.Selection._setSelection7489 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;I)V");
			global::android.text.Selection._getSelectionStart7490 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "getSelectionStart", "(Ljava/lang/CharSequence;)I");
			global::android.text.Selection._getSelectionEnd7491 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "getSelectionEnd", "(Ljava/lang/CharSequence;)I");
			global::android.text.Selection._extendSelection7492 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendSelection", "(Landroid/text/Spannable;I)V");
			global::android.text.Selection._removeSelection7493 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "removeSelection", "(Landroid/text/Spannable;)V");
			global::android.text.Selection._moveUp7494 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveDown7495 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveLeft7496 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveRight7497 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendUp7498 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendDown7499 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendLeft7500 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendRight7501 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendToLeftEdge7502 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendToRightEdge7503 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveToLeftEdge7504 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveToRightEdge7505 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
		}
	}
}
