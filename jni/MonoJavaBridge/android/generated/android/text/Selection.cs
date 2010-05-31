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
		internal static global::net.sf.jni4net.jni.MethodId _selectAll6861;
		public static void selectAll(android.text.Spannable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._selectAll6861, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection6862;
		public static void setSelection(android.text.Spannable arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._setSelection6862, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection6863;
		public static void setSelection(android.text.Spannable arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._setSelection6863, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionStart6864;
		public static int getSelectionStart(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._getSelectionStart6864, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionEnd6865;
		public static int getSelectionEnd(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._getSelectionEnd6865, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendSelection6866;
		public static void extendSelection(android.text.Spannable arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._extendSelection6866, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeSelection6867;
		public static void removeSelection(android.text.Spannable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._removeSelection6867, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveUp6868;
		public static bool moveUp(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveUp6868, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveDown6869;
		public static bool moveDown(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveDown6869, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveLeft6870;
		public static bool moveLeft(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveLeft6870, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveRight6871;
		public static bool moveRight(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveRight6871, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendUp6872;
		public static bool extendUp(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendUp6872, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendDown6873;
		public static bool extendDown(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendDown6873, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendLeft6874;
		public static bool extendLeft(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendLeft6874, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendRight6875;
		public static bool extendRight(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendRight6875, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendToLeftEdge6876;
		public static bool extendToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendToLeftEdge6876, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendToRightEdge6877;
		public static bool extendToRightEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendToRightEdge6877, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToLeftEdge6878;
		public static bool moveToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveToLeftEdge6878, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToRightEdge6879;
		public static bool moveToRightEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveToRightEdge6879, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.FieldId _SELECTION_START6880;
		public static global::java.lang.Object SELECTION_START
		{
			get
			{
				return default(global::java.lang.Object);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _SELECTION_END6881;
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
			global::android.text.Selection._selectAll6861 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "selectAll", "(Landroid/text/Spannable;)V");
			global::android.text.Selection._setSelection6862 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;II)V");
			global::android.text.Selection._setSelection6863 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;I)V");
			global::android.text.Selection._getSelectionStart6864 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "getSelectionStart", "(Ljava/lang/CharSequence;)I");
			global::android.text.Selection._getSelectionEnd6865 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "getSelectionEnd", "(Ljava/lang/CharSequence;)I");
			global::android.text.Selection._extendSelection6866 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendSelection", "(Landroid/text/Spannable;I)V");
			global::android.text.Selection._removeSelection6867 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "removeSelection", "(Landroid/text/Spannable;)V");
			global::android.text.Selection._moveUp6868 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveDown6869 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveLeft6870 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveRight6871 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendUp6872 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendDown6873 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendLeft6874 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendRight6875 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendToLeftEdge6876 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendToRightEdge6877 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveToLeftEdge6878 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveToRightEdge6879 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
		}
	}
}
