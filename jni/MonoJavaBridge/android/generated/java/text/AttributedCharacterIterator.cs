namespace java.text
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface AttributedCharacterIterator : CharacterIterator
	{
		global::java.util.Map getAttributes();
		global::java.lang.Object getAttribute(java.text.AttributedCharacterIterator_Attribute arg0);
		int getRunStart(java.util.Set arg0);
		int getRunStart(java.text.AttributedCharacterIterator_Attribute arg0);
		int getRunStart();
		int getRunLimit(java.text.AttributedCharacterIterator_Attribute arg0);
		int getRunLimit();
		int getRunLimit(java.util.Set arg0);
		global::java.util.Set getAllAttributeKeys();
	}

	public partial class AttributedCharacterIterator_
	{
		public static global::java.lang.Class _class
		{
			get { return __AttributedCharacterIterator.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __AttributedCharacterIterator : java.lang.Object, AttributedCharacterIterator
	{
		internal static global::java.lang.Class staticClass;
		static __AttributedCharacterIterator()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.text.__AttributedCharacterIterator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.text.__AttributedCharacterIterator(@__env);
			}
		}
		internal __AttributedCharacterIterator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributes13365;
		 global::java.util.Map java.text.AttributedCharacterIterator.getAttributes() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator._getAttributes13365));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getAttributes13365));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttribute13366;
		 global::java.lang.Object java.text.AttributedCharacterIterator.getAttribute(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator._getAttribute13366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getAttribute13366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunStart13367;
		 int java.text.AttributedCharacterIterator.getRunStart(java.util.Set arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunStart13367, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunStart13367, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunStart13368;
		 int java.text.AttributedCharacterIterator.getRunStart(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunStart13368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunStart13368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunStart13369;
		 int java.text.AttributedCharacterIterator.getRunStart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunStart13369);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunStart13369);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunLimit13370;
		 int java.text.AttributedCharacterIterator.getRunLimit(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunLimit13370, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunLimit13370, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunLimit13371;
		 int java.text.AttributedCharacterIterator.getRunLimit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunLimit13371);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunLimit13371);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunLimit13372;
		 int java.text.AttributedCharacterIterator.getRunLimit(java.util.Set arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunLimit13372, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunLimit13372, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllAttributeKeys13373;
		 global::java.util.Set java.text.AttributedCharacterIterator.getAllAttributeKeys() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator._getAllAttributeKeys13373));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getAllAttributeKeys13373));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone13374;
		 global::java.lang.Object java.text.CharacterIterator.clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator._clone13374));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._clone13374));
		}
		internal static global::net.sf.jni4net.jni.MethodId _next13375;
		 char java.text.CharacterIterator.next() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._next13375);
			else
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._next13375);
		}
		internal static global::net.sf.jni4net.jni.MethodId _previous13376;
		 char java.text.CharacterIterator.previous() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._previous13376);
			else
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._previous13376);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIndex13377;
		 int java.text.CharacterIterator.getIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getIndex13377);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getIndex13377);
		}
		internal static global::net.sf.jni4net.jni.MethodId _current13378;
		 char java.text.CharacterIterator.current() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._current13378);
			else
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._current13378);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIndex13379;
		 char java.text.CharacterIterator.setIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._setIndex13379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._setIndex13379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBeginIndex13380;
		 int java.text.CharacterIterator.getBeginIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getBeginIndex13380);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getBeginIndex13380);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEndIndex13381;
		 int java.text.CharacterIterator.getEndIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getEndIndex13381);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getEndIndex13381);
		}
		internal static global::net.sf.jni4net.jni.MethodId _last13382;
		 char java.text.CharacterIterator.last() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._last13382);
			else
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._last13382);
		}
		internal static global::net.sf.jni4net.jni.MethodId _first13383;
		 char java.text.CharacterIterator.first() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._first13383);
			else
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._first13383);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.text.__AttributedCharacterIterator.staticClass = @__class;
			global::java.text.__AttributedCharacterIterator._getAttributes13365 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getAttributes", "()Ljava/util/Map;");
			global::java.text.__AttributedCharacterIterator._getAttribute13366 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/lang/Object;");
			global::java.text.__AttributedCharacterIterator._getRunStart13367 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunStart", "(Ljava/util/Set;)I");
			global::java.text.__AttributedCharacterIterator._getRunStart13368 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunStart", "(Ljava/text/AttributedCharacterIterator$Attribute;)I");
			global::java.text.__AttributedCharacterIterator._getRunStart13369 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunStart", "()I");
			global::java.text.__AttributedCharacterIterator._getRunLimit13370 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunLimit", "(Ljava/text/AttributedCharacterIterator$Attribute;)I");
			global::java.text.__AttributedCharacterIterator._getRunLimit13371 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunLimit", "()I");
			global::java.text.__AttributedCharacterIterator._getRunLimit13372 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunLimit", "(Ljava/util/Set;)I");
			global::java.text.__AttributedCharacterIterator._getAllAttributeKeys13373 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getAllAttributeKeys", "()Ljava/util/Set;");
			global::java.text.__AttributedCharacterIterator._clone13374 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.clone", "()Ljava/lang/Object;");
			global::java.text.__AttributedCharacterIterator._next13375 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.next", "()C");
			global::java.text.__AttributedCharacterIterator._previous13376 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.previous", "()C");
			global::java.text.__AttributedCharacterIterator._getIndex13377 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.getIndex", "()I");
			global::java.text.__AttributedCharacterIterator._current13378 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.current", "()C");
			global::java.text.__AttributedCharacterIterator._setIndex13379 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.setIndex", "(I)C");
			global::java.text.__AttributedCharacterIterator._getBeginIndex13380 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.getBeginIndex", "()I");
			global::java.text.__AttributedCharacterIterator._getEndIndex13381 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.getEndIndex", "()I");
			global::java.text.__AttributedCharacterIterator._last13382 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.last", "()C");
			global::java.text.__AttributedCharacterIterator._first13383 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.first", "()C");
		}
	}
}
