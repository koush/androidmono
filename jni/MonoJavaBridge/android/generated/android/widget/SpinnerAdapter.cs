namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface SpinnerAdapter : Adapter
	{
		global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2);
	}

	public partial class SpinnerAdapter_
	{
		public static global::java.lang.Class _class
		{
			get { return __SpinnerAdapter.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __SpinnerAdapter : java.lang.Object, SpinnerAdapter
	{
		internal static global::java.lang.Class staticClass;
		static __SpinnerAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.__SpinnerAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.__SpinnerAdapter(@__env);
			}
		}
		internal __SpinnerAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView11612;
		 global::android.view.View android.widget.SpinnerAdapter.getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__SpinnerAdapter._getDropDownView11612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__SpinnerAdapter.staticClass, global::android.widget.__SpinnerAdapter._getDropDownView11612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty11613;
		 bool android.widget.Adapter.isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__SpinnerAdapter._isEmpty11613);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__SpinnerAdapter.staticClass, global::android.widget.__SpinnerAdapter._isEmpty11613);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount11614;
		 int android.widget.Adapter.getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__SpinnerAdapter._getCount11614);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__SpinnerAdapter.staticClass, global::android.widget.__SpinnerAdapter._getCount11614);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver11615;
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__SpinnerAdapter._registerDataSetObserver11615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__SpinnerAdapter.staticClass, global::android.widget.__SpinnerAdapter._registerDataSetObserver11615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver11616;
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__SpinnerAdapter._unregisterDataSetObserver11616, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__SpinnerAdapter.staticClass, global::android.widget.__SpinnerAdapter._unregisterDataSetObserver11616, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem11617;
		 global::java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__SpinnerAdapter._getItem11617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__SpinnerAdapter.staticClass, global::android.widget.__SpinnerAdapter._getItem11617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemId11618;
		 long android.widget.Adapter.getItemId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.__SpinnerAdapter._getItemId11618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__SpinnerAdapter.staticClass, global::android.widget.__SpinnerAdapter._getItemId11618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds11619;
		 bool android.widget.Adapter.hasStableIds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__SpinnerAdapter._hasStableIds11619);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__SpinnerAdapter.staticClass, global::android.widget.__SpinnerAdapter._hasStableIds11619);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getView11620;
		 global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__SpinnerAdapter._getView11620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__SpinnerAdapter.staticClass, global::android.widget.__SpinnerAdapter._getView11620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType11621;
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__SpinnerAdapter._getItemViewType11621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__SpinnerAdapter.staticClass, global::android.widget.__SpinnerAdapter._getItemViewType11621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount11622;
		 int android.widget.Adapter.getViewTypeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__SpinnerAdapter._getViewTypeCount11622);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__SpinnerAdapter.staticClass, global::android.widget.__SpinnerAdapter._getViewTypeCount11622);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.__SpinnerAdapter.staticClass = @__class;
			global::android.widget.__SpinnerAdapter._getDropDownView11612 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.SpinnerAdapter.getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.__SpinnerAdapter._isEmpty11613 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.isEmpty", "()Z");
			global::android.widget.__SpinnerAdapter._getCount11614 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getCount", "()I");
			global::android.widget.__SpinnerAdapter._registerDataSetObserver11615 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.__SpinnerAdapter._unregisterDataSetObserver11616 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.__SpinnerAdapter._getItem11617 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getItem", "(I)Ljava/lang/Object;");
			global::android.widget.__SpinnerAdapter._getItemId11618 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getItemId", "(I)J");
			global::android.widget.__SpinnerAdapter._hasStableIds11619 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.hasStableIds", "()Z");
			global::android.widget.__SpinnerAdapter._getView11620 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.__SpinnerAdapter._getItemViewType11621 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getItemViewType", "(I)I");
			global::android.widget.__SpinnerAdapter._getViewTypeCount11622 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getViewTypeCount", "()I");
		}
	}
}
