namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Character : java.lang.Object, java.io.Serializable, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Character()
		{
			InitJNI();
		}
		internal Character(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Subset : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Subset()
			{
				InitJNI();
			}
			protected Subset(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _equals14141;
			public sealed override bool equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Character.Subset._equals14141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._equals14141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString14142;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Character.Subset._toString14142)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._toString14142)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode14143;
			public sealed override int hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character.Subset._hashCode14143);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._hashCode14143);
			}
			internal static global::MonoJavaBridge.MethodId _Subset14144;
			protected Subset(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._Subset14144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Character.Subset.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character$Subset"));
				global::java.lang.Character.Subset._equals14141 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::java.lang.Character.Subset._toString14142 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "toString", "()Ljava/lang/String;");
				global::java.lang.Character.Subset._hashCode14143 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "hashCode", "()I");
				global::java.lang.Character.Subset._Subset14144 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class UnicodeBlock : java.lang.Character.Subset
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static UnicodeBlock()
			{
				InitJNI();
			}
			internal UnicodeBlock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _forName14145;
			public static global::java.lang.Character.UnicodeBlock forName(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._forName14145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			internal static global::MonoJavaBridge.MethodId _of14146;
			public static global::java.lang.Character.UnicodeBlock of(char arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._of14146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			internal static global::MonoJavaBridge.MethodId _of14147;
			public static global::java.lang.Character.UnicodeBlock of(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._of14147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			internal static global::MonoJavaBridge.FieldId _BASIC_LATIN14148;
			public static global::java.lang.Character.UnicodeBlock BASIC_LATIN
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_1_SUPPLEMENT14149;
			public static global::java.lang.Character.UnicodeBlock LATIN_1_SUPPLEMENT
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_A14150;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_A
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_B14151;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_B
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _IPA_EXTENSIONS14152;
			public static global::java.lang.Character.UnicodeBlock IPA_EXTENSIONS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPACING_MODIFIER_LETTERS14153;
			public static global::java.lang.Character.UnicodeBlock SPACING_MODIFIER_LETTERS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_DIACRITICAL_MARKS14154;
			public static global::java.lang.Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _GREEK14155;
			public static global::java.lang.Character.UnicodeBlock GREEK
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYRILLIC14156;
			public static global::java.lang.Character.UnicodeBlock CYRILLIC
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARMENIAN14157;
			public static global::java.lang.Character.UnicodeBlock ARMENIAN
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HEBREW14158;
			public static global::java.lang.Character.UnicodeBlock HEBREW
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC14159;
			public static global::java.lang.Character.UnicodeBlock ARABIC
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DEVANAGARI14160;
			public static global::java.lang.Character.UnicodeBlock DEVANAGARI
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BENGALI14161;
			public static global::java.lang.Character.UnicodeBlock BENGALI
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _GURMUKHI14162;
			public static global::java.lang.Character.UnicodeBlock GURMUKHI
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _GUJARATI14163;
			public static global::java.lang.Character.UnicodeBlock GUJARATI
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ORIYA14164;
			public static global::java.lang.Character.UnicodeBlock ORIYA
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAMIL14165;
			public static global::java.lang.Character.UnicodeBlock TAMIL
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TELUGU14166;
			public static global::java.lang.Character.UnicodeBlock TELUGU
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANNADA14167;
			public static global::java.lang.Character.UnicodeBlock KANNADA
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MALAYALAM14168;
			public static global::java.lang.Character.UnicodeBlock MALAYALAM
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _THAI14169;
			public static global::java.lang.Character.UnicodeBlock THAI
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LAO14170;
			public static global::java.lang.Character.UnicodeBlock LAO
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIBETAN14171;
			public static global::java.lang.Character.UnicodeBlock TIBETAN
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _GEORGIAN14172;
			public static global::java.lang.Character.UnicodeBlock GEORGIAN
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_JAMO14173;
			public static global::java.lang.Character.UnicodeBlock HANGUL_JAMO
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_ADDITIONAL14174;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_ADDITIONAL
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _GREEK_EXTENDED14175;
			public static global::java.lang.Character.UnicodeBlock GREEK_EXTENDED
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _GENERAL_PUNCTUATION14176;
			public static global::java.lang.Character.UnicodeBlock GENERAL_PUNCTUATION
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPERSCRIPTS_AND_SUBSCRIPTS14177;
			public static global::java.lang.Character.UnicodeBlock SUPERSCRIPTS_AND_SUBSCRIPTS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CURRENCY_SYMBOLS14178;
			public static global::java.lang.Character.UnicodeBlock CURRENCY_SYMBOLS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_MARKS_FOR_SYMBOLS14179;
			public static global::java.lang.Character.UnicodeBlock COMBINING_MARKS_FOR_SYMBOLS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LETTERLIKE_SYMBOLS14180;
			public static global::java.lang.Character.UnicodeBlock LETTERLIKE_SYMBOLS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NUMBER_FORMS14181;
			public static global::java.lang.Character.UnicodeBlock NUMBER_FORMS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARROWS14182;
			public static global::java.lang.Character.UnicodeBlock ARROWS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATHEMATICAL_OPERATORS14183;
			public static global::java.lang.Character.UnicodeBlock MATHEMATICAL_OPERATORS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_TECHNICAL14184;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_TECHNICAL
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTROL_PICTURES14185;
			public static global::java.lang.Character.UnicodeBlock CONTROL_PICTURES
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _OPTICAL_CHARACTER_RECOGNITION14186;
			public static global::java.lang.Character.UnicodeBlock OPTICAL_CHARACTER_RECOGNITION
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ENCLOSED_ALPHANUMERICS14187;
			public static global::java.lang.Character.UnicodeBlock ENCLOSED_ALPHANUMERICS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOX_DRAWING14188;
			public static global::java.lang.Character.UnicodeBlock BOX_DRAWING
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BLOCK_ELEMENTS14189;
			public static global::java.lang.Character.UnicodeBlock BLOCK_ELEMENTS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _GEOMETRIC_SHAPES14190;
			public static global::java.lang.Character.UnicodeBlock GEOMETRIC_SHAPES
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_SYMBOLS14191;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DINGBATS14192;
			public static global::java.lang.Character.UnicodeBlock DINGBATS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_SYMBOLS_AND_PUNCTUATION14193;
			public static global::java.lang.Character.UnicodeBlock CJK_SYMBOLS_AND_PUNCTUATION
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIRAGANA14194;
			public static global::java.lang.Character.UnicodeBlock HIRAGANA
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _KATAKANA14195;
			public static global::java.lang.Character.UnicodeBlock KATAKANA
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOPOMOFO14196;
			public static global::java.lang.Character.UnicodeBlock BOPOMOFO
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_COMPATIBILITY_JAMO14197;
			public static global::java.lang.Character.UnicodeBlock HANGUL_COMPATIBILITY_JAMO
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANBUN14198;
			public static global::java.lang.Character.UnicodeBlock KANBUN
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ENCLOSED_CJK_LETTERS_AND_MONTHS14199;
			public static global::java.lang.Character.UnicodeBlock ENCLOSED_CJK_LETTERS_AND_MONTHS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY14200;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS14201;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_SYLLABLES14202;
			public static global::java.lang.Character.UnicodeBlock HANGUL_SYLLABLES
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _PRIVATE_USE_AREA14203;
			public static global::java.lang.Character.UnicodeBlock PRIVATE_USE_AREA
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_IDEOGRAPHS14204;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALPHABETIC_PRESENTATION_FORMS14205;
			public static global::java.lang.Character.UnicodeBlock ALPHABETIC_PRESENTATION_FORMS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC_PRESENTATION_FORMS_A14206;
			public static global::java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_A
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_HALF_MARKS14207;
			public static global::java.lang.Character.UnicodeBlock COMBINING_HALF_MARKS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_FORMS14208;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_FORMS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALL_FORM_VARIANTS14209;
			public static global::java.lang.Character.UnicodeBlock SMALL_FORM_VARIANTS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC_PRESENTATION_FORMS_B14210;
			public static global::java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_B
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HALFWIDTH_AND_FULLWIDTH_FORMS14211;
			public static global::java.lang.Character.UnicodeBlock HALFWIDTH_AND_FULLWIDTH_FORMS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIALS14212;
			public static global::java.lang.Character.UnicodeBlock SPECIALS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SURROGATES_AREA14213;
			public static global::java.lang.Character.UnicodeBlock SURROGATES_AREA
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SYRIAC14214;
			public static global::java.lang.Character.UnicodeBlock SYRIAC
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _THAANA14215;
			public static global::java.lang.Character.UnicodeBlock THAANA
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SINHALA14216;
			public static global::java.lang.Character.UnicodeBlock SINHALA
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MYANMAR14217;
			public static global::java.lang.Character.UnicodeBlock MYANMAR
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ETHIOPIC14218;
			public static global::java.lang.Character.UnicodeBlock ETHIOPIC
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CHEROKEE14219;
			public static global::java.lang.Character.UnicodeBlock CHEROKEE
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS14220;
			public static global::java.lang.Character.UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _OGHAM14221;
			public static global::java.lang.Character.UnicodeBlock OGHAM
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNIC14222;
			public static global::java.lang.Character.UnicodeBlock RUNIC
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _KHMER14223;
			public static global::java.lang.Character.UnicodeBlock KHMER
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MONGOLIAN14224;
			public static global::java.lang.Character.UnicodeBlock MONGOLIAN
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BRAILLE_PATTERNS14225;
			public static global::java.lang.Character.UnicodeBlock BRAILLE_PATTERNS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_RADICALS_SUPPLEMENT14226;
			public static global::java.lang.Character.UnicodeBlock CJK_RADICALS_SUPPLEMENT
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANGXI_RADICALS14227;
			public static global::java.lang.Character.UnicodeBlock KANGXI_RADICALS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _IDEOGRAPHIC_DESCRIPTION_CHARACTERS14228;
			public static global::java.lang.Character.UnicodeBlock IDEOGRAPHIC_DESCRIPTION_CHARACTERS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOPOMOFO_EXTENDED14229;
			public static global::java.lang.Character.UnicodeBlock BOPOMOFO_EXTENDED
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A14230;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _YI_SYLLABLES14231;
			public static global::java.lang.Character.UnicodeBlock YI_SYLLABLES
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _YI_RADICALS14232;
			public static global::java.lang.Character.UnicodeBlock YI_RADICALS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYRILLIC_SUPPLEMENTARY14233;
			public static global::java.lang.Character.UnicodeBlock CYRILLIC_SUPPLEMENTARY
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGALOG14234;
			public static global::java.lang.Character.UnicodeBlock TAGALOG
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANUNOO14235;
			public static global::java.lang.Character.UnicodeBlock HANUNOO
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BUHID14236;
			public static global::java.lang.Character.UnicodeBlock BUHID
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGBANWA14237;
			public static global::java.lang.Character.UnicodeBlock TAGBANWA
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LIMBU14238;
			public static global::java.lang.Character.UnicodeBlock LIMBU
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAI_LE14239;
			public static global::java.lang.Character.UnicodeBlock TAI_LE
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _KHMER_SYMBOLS14240;
			public static global::java.lang.Character.UnicodeBlock KHMER_SYMBOLS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _PHONETIC_EXTENSIONS14241;
			public static global::java.lang.Character.UnicodeBlock PHONETIC_EXTENSIONS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A14242;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_ARROWS_A14243;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_A
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_ARROWS_B14244;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_B
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B14245;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_MATHEMATICAL_OPERATORS14246;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_MATHEMATICAL_OPERATORS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_SYMBOLS_AND_ARROWS14247;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_ARROWS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _KATAKANA_PHONETIC_EXTENSIONS14248;
			public static global::java.lang.Character.UnicodeBlock KATAKANA_PHONETIC_EXTENSIONS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _YIJING_HEXAGRAM_SYMBOLS14249;
			public static global::java.lang.Character.UnicodeBlock YIJING_HEXAGRAM_SYMBOLS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _VARIATION_SELECTORS14250;
			public static global::java.lang.Character.UnicodeBlock VARIATION_SELECTORS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LINEAR_B_SYLLABARY14251;
			public static global::java.lang.Character.UnicodeBlock LINEAR_B_SYLLABARY
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LINEAR_B_IDEOGRAMS14252;
			public static global::java.lang.Character.UnicodeBlock LINEAR_B_IDEOGRAMS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _AEGEAN_NUMBERS14253;
			public static global::java.lang.Character.UnicodeBlock AEGEAN_NUMBERS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _OLD_ITALIC14254;
			public static global::java.lang.Character.UnicodeBlock OLD_ITALIC
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _GOTHIC14255;
			public static global::java.lang.Character.UnicodeBlock GOTHIC
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _UGARITIC14256;
			public static global::java.lang.Character.UnicodeBlock UGARITIC
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DESERET14257;
			public static global::java.lang.Character.UnicodeBlock DESERET
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SHAVIAN14258;
			public static global::java.lang.Character.UnicodeBlock SHAVIAN
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _OSMANYA14259;
			public static global::java.lang.Character.UnicodeBlock OSMANYA
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYPRIOT_SYLLABARY14260;
			public static global::java.lang.Character.UnicodeBlock CYPRIOT_SYLLABARY
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BYZANTINE_MUSICAL_SYMBOLS14261;
			public static global::java.lang.Character.UnicodeBlock BYZANTINE_MUSICAL_SYMBOLS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MUSICAL_SYMBOLS14262;
			public static global::java.lang.Character.UnicodeBlock MUSICAL_SYMBOLS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAI_XUAN_JING_SYMBOLS14263;
			public static global::java.lang.Character.UnicodeBlock TAI_XUAN_JING_SYMBOLS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATHEMATICAL_ALPHANUMERIC_SYMBOLS14264;
			public static global::java.lang.Character.UnicodeBlock MATHEMATICAL_ALPHANUMERIC_SYMBOLS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B14265;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT14266;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGS14267;
			public static global::java.lang.Character.UnicodeBlock TAGS
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _VARIATION_SELECTORS_SUPPLEMENT14268;
			public static global::java.lang.Character.UnicodeBlock VARIATION_SELECTORS_SUPPLEMENT
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTARY_PRIVATE_USE_AREA_A14269;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_A
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTARY_PRIVATE_USE_AREA_B14270;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_B
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIGH_SURROGATES14271;
			public static global::java.lang.Character.UnicodeBlock HIGH_SURROGATES
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIGH_PRIVATE_USE_SURROGATES14272;
			public static global::java.lang.Character.UnicodeBlock HIGH_PRIVATE_USE_SURROGATES
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOW_SURROGATES14273;
			public static global::java.lang.Character.UnicodeBlock LOW_SURROGATES
			{
				get
				{
					return default(global::java.lang.Character.UnicodeBlock);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Character.UnicodeBlock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character$UnicodeBlock"));
				global::java.lang.Character.UnicodeBlock._forName14145 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "forName", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._of14146 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "of", "(C)Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._of14147 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "of", "(I)Ljava/lang/Character$UnicodeBlock;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierStart14274;
		public static bool isJavaIdentifierStart(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierStart14274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierStart14275;
		public static bool isJavaIdentifierStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierStart14275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierPart14276;
		public static bool isJavaIdentifierPart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierPart14276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierPart14277;
		public static bool isJavaIdentifierPart(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierPart14277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals14278;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Character._equals14278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._equals14278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14279;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Character._toString14279)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._toString14279)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString14280;
		public static global::java.lang.String toString(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._toString14280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14281;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character._hashCode14281);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._hashCode14281);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes14282;
		public static char reverseBytes(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._reverseBytes14282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14283;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character._compareTo14283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._compareTo14283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14284;
		public int compareTo(java.lang.Character arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character._compareTo14284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._compareTo14284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt14285;
		public static int codePointAt(char[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointAt14285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt14286;
		public static int codePointAt(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointAt14286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt14287;
		public static int codePointAt(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointAt14287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore14288;
		public static int codePointBefore(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointBefore14288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore14289;
		public static int codePointBefore(char[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointBefore14289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore14290;
		public static int codePointBefore(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointBefore14290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount14291;
		public static int codePointCount(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointCount14291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount14292;
		public static int codePointCount(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointCount14292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints14293;
		public static int offsetByCodePoints(char[] arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._offsetByCodePoints14293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints14294;
		public static int offsetByCodePoints(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._offsetByCodePoints14294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toLowerCase14295;
		public static int toLowerCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toLowerCase14295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toLowerCase14296;
		public static char toLowerCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._toLowerCase14296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toUpperCase14297;
		public static char toUpperCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._toUpperCase14297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toUpperCase14298;
		public static int toUpperCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toUpperCase14298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14299;
		public static global::java.lang.Character valueOf(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._valueOf14299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character;
		}
		internal static global::MonoJavaBridge.MethodId _toChars14300;
		public static char[] toChars(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._toChars14300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _toChars14301;
		public static int toChars(int arg0, char[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toChars14301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _charCount14302;
		public static int charCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._charCount14302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getType14303;
		public static int getType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getType14303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getType14304;
		public static int getType(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getType14304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isValidCodePoint14305;
		public static bool isValidCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isValidCodePoint14305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLowSurrogate14306;
		public static bool isLowSurrogate(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLowSurrogate14306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHighSurrogate14307;
		public static bool isHighSurrogate(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isHighSurrogate14307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _charValue14308;
		public char charValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.Character._charValue14308);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._charValue14308);
		}
		internal static global::MonoJavaBridge.MethodId _isSupplementaryCodePoint14309;
		public static bool isSupplementaryCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSupplementaryCodePoint14309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSurrogatePair14310;
		public static bool isSurrogatePair(char arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSurrogatePair14310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toCodePoint14311;
		public static int toCodePoint(char arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toCodePoint14311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLowerCase14312;
		public static bool isLowerCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLowerCase14312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLowerCase14313;
		public static bool isLowerCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLowerCase14313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUpperCase14314;
		public static bool isUpperCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUpperCase14314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUpperCase14315;
		public static bool isUpperCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUpperCase14315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTitleCase14316;
		public static bool isTitleCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isTitleCase14316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTitleCase14317;
		public static bool isTitleCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isTitleCase14317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDigit14318;
		public static bool isDigit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDigit14318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDigit14319;
		public static bool isDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDigit14319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDefined14320;
		public static bool isDefined(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDefined14320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDefined14321;
		public static bool isDefined(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDefined14321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetter14322;
		public static bool isLetter(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetter14322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetter14323;
		public static bool isLetter(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetter14323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetterOrDigit14324;
		public static bool isLetterOrDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetterOrDigit14324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetterOrDigit14325;
		public static bool isLetterOrDigit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetterOrDigit14325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaLetter14326;
		public static bool isJavaLetter(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaLetter14326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaLetterOrDigit14327;
		public static bool isJavaLetterOrDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaLetterOrDigit14327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierStart14328;
		public static bool isUnicodeIdentifierStart(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierStart14328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierStart14329;
		public static bool isUnicodeIdentifierStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierStart14329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierPart14330;
		public static bool isUnicodeIdentifierPart(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierPart14330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierPart14331;
		public static bool isUnicodeIdentifierPart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierPart14331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIdentifierIgnorable14332;
		public static bool isIdentifierIgnorable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isIdentifierIgnorable14332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIdentifierIgnorable14333;
		public static bool isIdentifierIgnorable(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isIdentifierIgnorable14333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toTitleCase14334;
		public static char toTitleCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._toTitleCase14334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toTitleCase14335;
		public static int toTitleCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toTitleCase14335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _digit14336;
		public static int digit(char arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._digit14336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _digit14337;
		public static int digit(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._digit14337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNumericValue14338;
		public static int getNumericValue(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getNumericValue14338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumericValue14339;
		public static int getNumericValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getNumericValue14339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpace14340;
		public static bool isSpace(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSpace14340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpaceChar14341;
		public static bool isSpaceChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSpaceChar14341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpaceChar14342;
		public static bool isSpaceChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSpaceChar14342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace14343;
		public static bool isWhitespace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isWhitespace14343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace14344;
		public static bool isWhitespace(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isWhitespace14344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isISOControl14345;
		public static bool isISOControl(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isISOControl14345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isISOControl14346;
		public static bool isISOControl(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isISOControl14346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _forDigit14347;
		public static char forDigit(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._forDigit14347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDirectionality14348;
		public static byte getDirectionality(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Character.staticClass, global::java.lang.Character._getDirectionality14348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDirectionality14349;
		public static byte getDirectionality(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Character.staticClass, global::java.lang.Character._getDirectionality14349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMirrored14350;
		public static bool isMirrored(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isMirrored14350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMirrored14351;
		public static bool isMirrored(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isMirrored14351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Character14352;
		public Character(char arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Character.staticClass, global::java.lang.Character._Character14352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Character.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character"));
			global::java.lang.Character._isJavaIdentifierStart14274 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierStart", "(C)Z");
			global::java.lang.Character._isJavaIdentifierStart14275 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierStart", "(I)Z");
			global::java.lang.Character._isJavaIdentifierPart14276 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierPart", "(I)Z");
			global::java.lang.Character._isJavaIdentifierPart14277 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierPart", "(C)Z");
			global::java.lang.Character._equals14278 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Character._toString14279 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Character._toString14280 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toString", "(C)Ljava/lang/String;");
			global::java.lang.Character._hashCode14281 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "hashCode", "()I");
			global::java.lang.Character._reverseBytes14282 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "reverseBytes", "(C)C");
			global::java.lang.Character._compareTo14283 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Character._compareTo14284 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "compareTo", "(Ljava/lang/Character;)I");
			global::java.lang.Character._codePointAt14285 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "([CI)I");
			global::java.lang.Character._codePointAt14286 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "(Ljava/lang/CharSequence;I)I");
			global::java.lang.Character._codePointAt14287 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "([CII)I");
			global::java.lang.Character._codePointBefore14288 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "(Ljava/lang/CharSequence;I)I");
			global::java.lang.Character._codePointBefore14289 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "([CI)I");
			global::java.lang.Character._codePointBefore14290 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "([CII)I");
			global::java.lang.Character._codePointCount14291 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointCount", "(Ljava/lang/CharSequence;II)I");
			global::java.lang.Character._codePointCount14292 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointCount", "([CII)I");
			global::java.lang.Character._offsetByCodePoints14293 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "offsetByCodePoints", "([CIIII)I");
			global::java.lang.Character._offsetByCodePoints14294 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "offsetByCodePoints", "(Ljava/lang/CharSequence;II)I");
			global::java.lang.Character._toLowerCase14295 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toLowerCase", "(I)I");
			global::java.lang.Character._toLowerCase14296 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toLowerCase", "(C)C");
			global::java.lang.Character._toUpperCase14297 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toUpperCase", "(C)C");
			global::java.lang.Character._toUpperCase14298 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toUpperCase", "(I)I");
			global::java.lang.Character._valueOf14299 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "valueOf", "(C)Ljava/lang/Character;");
			global::java.lang.Character._toChars14300 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toChars", "(I)[C");
			global::java.lang.Character._toChars14301 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toChars", "(I[CI)I");
			global::java.lang.Character._charCount14302 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "charCount", "(I)I");
			global::java.lang.Character._getType14303 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getType", "(I)I");
			global::java.lang.Character._getType14304 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getType", "(C)I");
			global::java.lang.Character._isValidCodePoint14305 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isValidCodePoint", "(I)Z");
			global::java.lang.Character._isLowSurrogate14306 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowSurrogate", "(C)Z");
			global::java.lang.Character._isHighSurrogate14307 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isHighSurrogate", "(C)Z");
			global::java.lang.Character._charValue14308 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "charValue", "()C");
			global::java.lang.Character._isSupplementaryCodePoint14309 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSupplementaryCodePoint", "(I)Z");
			global::java.lang.Character._isSurrogatePair14310 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSurrogatePair", "(CC)Z");
			global::java.lang.Character._toCodePoint14311 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toCodePoint", "(CC)I");
			global::java.lang.Character._isLowerCase14312 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowerCase", "(I)Z");
			global::java.lang.Character._isLowerCase14313 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowerCase", "(C)Z");
			global::java.lang.Character._isUpperCase14314 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUpperCase", "(I)Z");
			global::java.lang.Character._isUpperCase14315 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUpperCase", "(C)Z");
			global::java.lang.Character._isTitleCase14316 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isTitleCase", "(C)Z");
			global::java.lang.Character._isTitleCase14317 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isTitleCase", "(I)Z");
			global::java.lang.Character._isDigit14318 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDigit", "(I)Z");
			global::java.lang.Character._isDigit14319 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDigit", "(C)Z");
			global::java.lang.Character._isDefined14320 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDefined", "(I)Z");
			global::java.lang.Character._isDefined14321 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDefined", "(C)Z");
			global::java.lang.Character._isLetter14322 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetter", "(C)Z");
			global::java.lang.Character._isLetter14323 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetter", "(I)Z");
			global::java.lang.Character._isLetterOrDigit14324 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetterOrDigit", "(C)Z");
			global::java.lang.Character._isLetterOrDigit14325 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetterOrDigit", "(I)Z");
			global::java.lang.Character._isJavaLetter14326 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaLetter", "(C)Z");
			global::java.lang.Character._isJavaLetterOrDigit14327 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaLetterOrDigit", "(C)Z");
			global::java.lang.Character._isUnicodeIdentifierStart14328 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierStart", "(C)Z");
			global::java.lang.Character._isUnicodeIdentifierStart14329 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierStart", "(I)Z");
			global::java.lang.Character._isUnicodeIdentifierPart14330 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierPart", "(C)Z");
			global::java.lang.Character._isUnicodeIdentifierPart14331 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierPart", "(I)Z");
			global::java.lang.Character._isIdentifierIgnorable14332 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isIdentifierIgnorable", "(I)Z");
			global::java.lang.Character._isIdentifierIgnorable14333 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isIdentifierIgnorable", "(C)Z");
			global::java.lang.Character._toTitleCase14334 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toTitleCase", "(C)C");
			global::java.lang.Character._toTitleCase14335 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toTitleCase", "(I)I");
			global::java.lang.Character._digit14336 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "digit", "(CI)I");
			global::java.lang.Character._digit14337 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "digit", "(II)I");
			global::java.lang.Character._getNumericValue14338 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getNumericValue", "(C)I");
			global::java.lang.Character._getNumericValue14339 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getNumericValue", "(I)I");
			global::java.lang.Character._isSpace14340 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpace", "(C)Z");
			global::java.lang.Character._isSpaceChar14341 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpaceChar", "(C)Z");
			global::java.lang.Character._isSpaceChar14342 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpaceChar", "(I)Z");
			global::java.lang.Character._isWhitespace14343 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isWhitespace", "(I)Z");
			global::java.lang.Character._isWhitespace14344 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isWhitespace", "(C)Z");
			global::java.lang.Character._isISOControl14345 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isISOControl", "(I)Z");
			global::java.lang.Character._isISOControl14346 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isISOControl", "(C)Z");
			global::java.lang.Character._forDigit14347 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "forDigit", "(II)C");
			global::java.lang.Character._getDirectionality14348 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getDirectionality", "(C)B");
			global::java.lang.Character._getDirectionality14349 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getDirectionality", "(I)B");
			global::java.lang.Character._isMirrored14350 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isMirrored", "(I)Z");
			global::java.lang.Character._isMirrored14351 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isMirrored", "(C)Z");
			global::java.lang.Character._Character14352 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "<init>", "(C)V");
		}
	}
}
